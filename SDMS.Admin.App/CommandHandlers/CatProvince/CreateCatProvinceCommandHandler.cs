using MediatR;
using SDMS.Admin.App.Commands.CatProvince;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.CommandHandlers.CatProvince
{
    public class CreateCatProvinceCommandHandler : IRequestHandler<CreateCatProvinceCommand>
    {
        private readonly IProvinceRepository _repository;

        public CreateCatProvinceCommandHandler(IProvinceRepository repository)
        {
            _repository = repository;
        }
        public Task<Unit> Handle(CreateCatProvinceCommand request, CancellationToken cancellationToken)
        {
            var entity = new Domain.Entities.CatProvince(request.ProvinceCode
                , request.ProvinceName, request.IsActive);
            _repository.Add(entity);
            return Task.FromResult(Unit.Value);
        }
    }
}
