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
    public class SysUserInformationExpression : IQueryExpression<SysUserInformation>
    {
        public Expression<Func<SysUserInformation, bool>> ToPredicate()
        {
            Expression<Func<SysUserInformation, bool>> exp = e => true;

            return exp;
        }
    }
}
