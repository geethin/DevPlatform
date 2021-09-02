
namespace Services.Repositories
{
    public class ArticleCatalogRepository : Repository<ArticleCatalog, ArticleCatalogAddDto, ArticleCatalogUpdateDto, ArticleCatalogFilter, ArticleCatalogDto>
    {
        public ArticleCatalogRepository(ContextBase context, ILogger<ArticleCatalogRepository> logger, IUserContext userContext, IMapper mapper) : base(context, logger, userContext, mapper)
        {
        }

        public Task<PageResult<ArticleCatalogDto>> GetListWithPageAsync(Guid accountId, ArticleCatalogFilter filter)
        {
            _query = _query.OrderByDescending(q => q.CreatedTime);
            _query = _query.Where(c => c.AccountId == accountId);
            return base.GetListWithPageAsync(filter);
        }


        public override Task<ArticleCatalog> AddAsync(ArticleCatalogAddDto form)
        {

            return base.AddAsync(form);
        }


        /// <summary>
        /// ��֤�û�
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public bool ValidAccount(Guid accountId)
        {
            return _context.ArticleCatalogs.Any(a => a.Account.Id == accountId);
        }
    }
}
