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
    public class DeleteProvinceCommandHandler : IRequestHandler<DeleteCatProvinceCommand>
    {
        private readonly IProvinceRepository _repository;

        public DeleteProvinceCommandHandler(IProvinceRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCatProvinceCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(request.ProvinceId);

            if (entity == null)
                throw new AppException("Entity not found");

            _repository.Remove(entity);

            return Unit.Value;
        }
    }
}
