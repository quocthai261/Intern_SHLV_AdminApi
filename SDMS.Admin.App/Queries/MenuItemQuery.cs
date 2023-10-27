using MediatR;
using PB22.Core.Misc;
using SDMS.Admin.App.Dtos;

namespace SDMS.Admin.App.Queries;

[NoTransaction]
public class MenuItemQuery : IRequest<List<SiteMapNode>>
{
    public bool IsActiveOnly { get; set; } = true;
    public int? SourceType { get; set; }
}