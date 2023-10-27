using MediatR;
using PB22.Core.Exceptions;
using SDMS.Admin.App.Commands.Nationality;
using SDMS.Admin.App.Commands.Province;
using SDMS.Admin.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.CommandHandlers.Province
{
    public class UpdateProvinceCommandHandler : IRequestHandler<UpdateCatProvinceCommand>
    {
        private readonly IProvinceRepository _repository;

        public UpdateProvinceCommandHandler(IProvinceRepository repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(UpdateCatProvinceCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(request.ProvinceId);

            if (entity == null)
                throw new AppException("Entity not found");

            entity.Update(request.ProvinceCode, request.ProvinceName, request.IsActive);
            //_repository.Update(entity);
            return Unit.Value;
        }
    }
}
