using PB22.Core.Infrastructure.QueryServices;
using SDMS.Admin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.QueryExpressions
{
    public class SysMenusExpression : IQueryExpression<SysMenu>
    {
        public Expression<Func<SysMenu, bool>> ToPredicate()
        {
            Expression<Func<SysMenu, bool>> exp = e => true;

            return exp;
        }
    }
}
