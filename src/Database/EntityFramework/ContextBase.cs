namespace EntityFramework;

public class ContextBase : DbContext
{
    public DbSet<Account> Accounts { get; set; } = null!;
    public DbSet<AccountExtend> AccountExtends { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<Article> Articles { get; set; } = null!;
    public DbSet<ArticleExtend> ArticleExtends { get; set; } = null!;
    public DbSet<ArticleCatalog> ArticleCatalogs { get; set; } = null!;
    public DbSet<LibraryCatalog> LibraryCatalogs { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;
    public DbSet<CodeSnippet> CodeSnippets { get; set; } = null!;
    public DbSet<Library> Libraries { get; set; } = null!;
    public DbSet<ThirdNews> ThirdNews { get; set; } = null!;
    public DbSet<NewsTags> NewsTags { get; set; } = null!;
    public DbSet<TagLibrary> TagLibraries { get; set; } = null!;

    public ContextBase(DbContextOptions<ContextBase> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // 默认配置
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Account>(e =>
        {
            e.HasIndex(a => a.Email);
            e.HasIndex(a => a.Phone);
            e.HasIndex(a => a.Username);
            e.HasIndex(a => a.IsDeleted);
            e.HasIndex(a => a.PhoneConfirm);
            e.HasIndex(a => a.EmailConfirm);
            e.HasIndex(a => a.CreatedTime);
            e.HasOne(a => a.Extend)
                .WithOne(e => e.Account)
                .HasForeignKey<AccountExtend>(e => e.AccountId);
        });
        builder.Entity<AccountExtend>(e =>
        {
            e.HasIndex(a => a.RealName);
            e.HasIndex(a => a.Country);
            e.HasIndex(a => a.Province);
            e.HasIndex(a => a.City);
        });

        builder.Entity<Role>(e =>
        {
            e.HasIndex(m => m.Name);
            e.HasIndex(m => m.Status);
        });

        builder.Entity<Library>(e =>
        {
            e.HasIndex(m => m.Language);
            e.HasIndex(m => m.IsValid);
            e.HasIndex(m => m.Namespace);
            e.HasIndex(m => m.IsPublic);
            e.HasIndex(m => m.CreatedTime);
        });

        builder.Entity<CodeSnippet>(e =>
        {
            e.HasIndex(m => m.CreatedTime);
            e.HasIndex(m => m.Name);
            e.HasIndex(m => m.Status);
            e.HasIndex(m => m.CodeType);
            e.HasIndex(m => m.Language);
        });

        builder.Entity<Article>(e =>
        {
            e.HasIndex(m => m.Title);
            e.HasIndex(m => m.CreatedTime);
            e.HasIndex(m => m.ArticleType);
            e.HasOne(a => a.Extend)
                .WithOne(e => e.Article)
                .HasForeignKey<ArticleExtend>(e => e.ArticleId);
        });
        builder.Entity<ArticleCatalog>(e =>
        {
            e.HasIndex(m => m.Name);
            e.HasIndex(m => m.Type);
            e.HasIndex(m => m.Sort);
            e.HasIndex(m => m.Level);
        });
        builder.Entity<LibraryCatalog>(e =>
        {
            e.HasIndex(m => m.Name);
            e.HasIndex(m => m.Type);
            e.HasIndex(m => m.Sort);
            e.HasIndex(m => m.Level);
        });
        builder.Entity<Comment>(e =>
        {
            e.HasIndex(m => m.CreatedTime);
        });

        builder.Entity<ThirdNews>(e =>
        {
            e.HasIndex(m => m.Title);
            e.HasIndex(m => m.DatePublished);
            e.HasIndex(m => m.Provider);
            e.HasIndex(m => m.Category);
            e.HasIndex(m => m.IdentityId);
            e.HasIndex(m => m.NewsType);
            e.HasIndex(m => m.Type);
        });

        base.OnModelCreating(builder);
    }
}
