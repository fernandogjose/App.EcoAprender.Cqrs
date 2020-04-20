using App.EcoAprender.Cqrs.Application.Compartilhado.ViewModels;
using App.EcoAprender.Cqrs.Application.Comunicado.Interfaces;
using App.EcoAprender.Cqrs.Application.Comunicado.ViewModels;
using App.EcoAprender.Cqrs.Domain.Compartilhado.Commands;
using App.EcoAprender.Cqrs.Domain.Comunicado.Commands;
using App.EcoAprender.Cqrs.Domain.Comunicado.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Comunicado.Queries;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace App.EcoAprender.Cqrs.Application.Comunicado.AppServices
{
    public class ComunicadoAppService : IComunicadoAppService
    {
        private readonly IMediator _mediator;
        private readonly IComunicadoRepository _comunicadoRepository;

        public ComunicadoAppService(IMediator mediator, IComunicadoRepository comunicadoRepository)
        {
            _mediator = mediator;
            _comunicadoRepository = comunicadoRepository;
        }

        public ResponseViewModel Listar()
        {
            IEnumerable<ComunicadoListarResponseQuery> comunicadosResponse = _comunicadoRepository.Listar();
            ResponseViewModel response = new ResponseViewModel(true, "Lista carregada com sucesso", comunicadosResponse);
            return response;
        }

        public async Task<ResponseViewModel> Adicionar(ComunicadoAdicionarRequestViewModel request)
        {
            ComunicadoAdicionarCommand comunicadoAdicionarCommand = new ComunicadoAdicionarCommand(request.Data, request.Titulo, request.Descricao, request.GrupoId);
            ResponseCommand responseCommand = await _mediator.Send(comunicadoAdicionarCommand, CancellationToken.None).ConfigureAwait(true);
            ResponseViewModel response = new ResponseViewModel(responseCommand.Sucesso, responseCommand.Mensagem, responseCommand.Objeto);

            return response;

        }
    }
}
