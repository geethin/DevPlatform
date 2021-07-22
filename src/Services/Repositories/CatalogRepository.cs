using AutoMapper;
using Core.Agreement;
using Share.Models;
using Entity;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Services.Repositories
{
    public class CatalogRepository : Repository<LibraryCatalog, CatalogAddDto, CatalogUpdateDto, CatalogFilter, CatalogDto>
    {
        public CatalogRepository(ContextBase context, ILogger<CatalogRepository> logger, IMapper mapper) : base(context, logger, mapper)
        {
        }

        public override Task<PageResult<CatalogDto>> GetListWithPageAsync(CatalogFilter filter)
        {
            _query = _query.OrderByDescending(q => q.CreatedTime);
            return base.GetListWithPageAsync(filter);
        }
    }
}
