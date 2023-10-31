using SDMS.Admin.App.Dtos.SysUserInformation;
using MediatR;

namespace SDMS.Admin.App.Queries.SysUserInformation
{
    public class GetUserInformationByUserIdQuery : IRequest<List<QuerySysUserInformationDto>>
    {
        public long UserId {  get; set; }   
    }
}
