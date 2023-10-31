using MapsterMapper;
using MediatR;
using PB22.Core.Infrastructure.QueryServices;
using SDMS.Admin.App.Dtos.SysUserInformation;
using SDMS.Admin.App.Queries.SysUserInformation;
using SDMS.Admin.App.Services;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.App.QueryHandlers
{
    public class GetUserInformationByUserIdQueryHandler : IRequestHandler<GetUserInformationByUserIdQuery, List<QuerySysUserInformationDto>>
    {
        private readonly IMapper _mapper;
        private readonly IQueryService _queryService;

        public GetUserInformationByUserIdQueryHandler(
            IMapper mapper,
            IQueryService queryService
            )
        {
            _mapper = mapper;
            _queryService = queryService;
        }

        public async Task<List<QuerySysUserInformationDto>> Handle(GetUserInformationByUserIdQuery request, CancellationToken cancellationToken)
        {
            var userInformationList = _queryService.GetQueryable<SysUserInformation>(q => q.UserId != 0).Where(q => q.UserId == request.UserId);
            var userInformationDto = _mapper.Map<List<QuerySysUserInformationDto>>(userInformationList);

            return userInformationDto;
        }
    }
}
