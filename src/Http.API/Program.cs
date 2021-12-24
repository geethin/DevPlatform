var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var configuration = builder.Configuration;

services.AddHttpContextAccessor();
services.AddAutoMapper(typeof(MapperProfile));
services.Configure<AzureOptions>(configuration.GetSection("Azure"));
var connectionString = configuration.GetConnectionString("DefaultConnection");
services.AddDbContextPool<ContextBase>(option =>
{
    option.UseNpgsql(connectionString, sql => { sql.MigrationsAssembly("EntityFrameworkCore"); });
});

services.AddScoped<IUserContext, UserContext>();
services.AddRepositories();
services.AddOptions();

services.AddScoped<NewsCollectionService>();
services.AddScoped<TwitterService>();
services.AddScoped(typeof(WebService));
services.AddScoped(typeof(FileService));

#region 接口相关内容:jwt/授权/cors
// jwt
services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(cfg =>
{
    //cfg.RequireHttpsMetadata = true;
    cfg.SaveToken = true;
    cfg.TokenValidationParameters = new TokenValidationParameters()
    {
        // 如果不如果jwt，可注释掉，你可能会使用IdentityServer
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("Jwt")["Sign"])),
        ValidIssuer = configuration.GetSection("Jwt")["Issuer"],
        ValidAudience = configuration.GetSection("Jwt")["Audience"],
        ValidateIssuer = true,
        ValidateLifetime = false,
        RequireExpirationTime = false,
        ValidateAudience = false,
        //ValidateIssuerSigningKey = true
    };
});
// 验证
services.AddAuthorization(options =>
{
    options.AddPolicy("User", policy =>
        policy.RequireRole("Admin", "User"));
    options.AddPolicy("Admin", policy =>
        policy.RequireRole("Admin"));
});

// services.AddScoped(typeof(JwtService)); 
// cors配置 
services.AddCors(options =>
{
    options.AddPolicy("default", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});
#endregion

// api 接口文档设置
services.AddOpenApiDocument(c =>
{
    c.GenerateXmlObjects = true;
    c.GenerateEnumMappingDescription = true;
    c.UseControllerSummaryAsTagDescription = true;
    c.PostProcess = (document) =>
    {
        document.Info.Title = "Dev Platform";
        document.Info.Description = "Api 文档";
        document.Info.Version = "1.0";
    };
});
services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseCors("default");
    app.UseDeveloperExceptionPage();
    app.UseOpenApi();
    app.UseSwaggerUi3(c => { c.DocumentTitle = "文档"; });
    app.UseStaticFiles();
}
else
{
    // 生产环境需要新的配置
    app.UseCors("default");
    app.UseExceptionHandler("/Home/Error");
    //app.UseHsts();
    app.UseHttpsRedirection();
}

app.UseHealthChecks("/health");
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});