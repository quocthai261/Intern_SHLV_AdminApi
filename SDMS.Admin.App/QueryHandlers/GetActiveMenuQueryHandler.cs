using DocumentFormat.OpenXml.Bibliography;
using MapsterMapper;
using MediatR;
using PB22.Core.Infrastructure.QueryServices;
using SDMS.Admin.App.Dtos.SysMenus;
using SDMS.Admin.App.Queries.SysMenus;
using SDMS.Admin.App.Services;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.App.QueryHandlers
{
    public class GetActiveMenuQueryHandler : IRequestHandler<GetActiveMenuQuery, List<QuerySysMenusDto>>
    {
        private readonly IMapper _mapper;
        private readonly IQueryService _queryService;

        public GetActiveMenuQueryHandler( 
            IMapper mapper,
            IQueryService queryService
            )
        {
            _mapper = mapper;
            _queryService = queryService;
        }

        public async Task<List<QuerySysMenusDto>> Handle(GetActiveMenuQuery request, CancellationToken cancellationToken)
        {
            var menus = _queryService.GetQueryable<SysMenu>(q => q.SourceType != 0).Where(q => q.SourceType == request.SourceType && q.IsActive == true);
            var menusDto = _mapper.Map<List<QuerySysMenusDto>>(menus);

            return menusDto;
        }
    }
}
