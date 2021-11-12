// 该控制器由GT.CLI自动生成,继承该类,可以实现基本的CURD Api接口,以及用户相关信息
// 可以直接继承ApiServiceBase基类,或实现IApiServiceBase接口,以实现自定义的http路由及方法
using App.Api.Agreement;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize("User")]
    public class ApiController<TRepository, TEntity, TAddForm, TUpdateForm, TFilter, TDto>
        : ApiControllerBase<ContextBase, TRepository, TEntity, TAddForm, TUpdateForm, TFilter, TDto>
        where TRepository : Repository<TEntity, TAddForm, TUpdateForm, TFilter, TDto>
        where TFilter : FilterBase
        where TEntity : BaseDB
    {
        protected readonly HttpContext _httpContext;
        protected readonly IUserContext _usrCtx;
        public ApiController(ILogger logger, TRepository repos,
            IUserContext userContext
            ) : base(logger, repos)
        {
            _usrCtx = userContext;
        }

        // 自定义逻辑及方法
    }
}
