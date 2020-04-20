using App.EcoAprender.Cqrs.Domain.Compartilhado.Commands;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace App.EcoAprender.Cqrs.Domain.Compartilhado.Pipelines
{
    public class ValidateCommand<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TResponse : ResponseCommand
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            if (request is RequestCommand requestCommand)
            {
                List<string> erros = requestCommand.Validar();
                if (erros.Any())
                {
                    ResponseCommand responseCommand = new ResponseCommand(false, "Favor validar os campos", erros);
                    return responseCommand as TResponse;
                }
            }

            TResponse result = await next();
            return result;
        }
    }
}
