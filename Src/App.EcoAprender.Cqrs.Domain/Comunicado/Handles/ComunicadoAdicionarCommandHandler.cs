using App.EcoAprender.Cqrs.Domain.Compartilhado.Commands;
using App.EcoAprender.Cqrs.Domain.Comunicado.Commands;
using App.EcoAprender.Cqrs.Domain.Comunicado.Interfaces.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace App.EcoAprender.Cqrs.Domain.Comunicado.Handles
{
    public class ComunicadoAdicionarCommandHandler : IRequestHandler<ComunicadoAdicionarCommand, ResponseCommand>
    {
        private readonly IComunicadoRepository _comunicadoRepository;

        public ComunicadoAdicionarCommandHandler(IComunicadoRepository comunicadoRepository)
        {
            _comunicadoRepository = comunicadoRepository;
        }

        public Task<ResponseCommand> Handle(ComunicadoAdicionarCommand request, CancellationToken cancellationToken)
        {
            // Persistir
            int responseRepository = _comunicadoRepository.Adicionar(request);

            // Notificar
            return Task.FromResult(new ResponseCommand(true, "Comunicado cadastrado com sucesso", responseRepository));
        }
    }
}
