using App.EcoAprender.Cqrs.Domain.Interfaces.Commands;

namespace App.EcoAprender.Cqrs.Domain.Commands
{
    public class ResponseCommand : IResponseCommand
    {
        public bool Sucesso { get; private set; }

        public string Mensagem { get; private set; }

        public object Objeto { get; private set; }

        public ResponseCommand(bool sucesso, string mensagem, object objeto)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Objeto = objeto;
        }
    }
}
