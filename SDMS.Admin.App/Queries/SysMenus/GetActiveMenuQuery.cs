using MediatR;
using SDMS.Admin.App.Dtos.SysMenus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Queries.SysMenus
{
    public class GetActiveMenuQuery : IRequest<List<QuerySysMenusDto>>
    {
        public int SourceType { get; set; }
    }
}
