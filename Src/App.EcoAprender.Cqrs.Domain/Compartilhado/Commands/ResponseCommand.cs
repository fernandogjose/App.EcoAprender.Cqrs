namespace App.EcoAprender.Cqrs.Domain.Compartilhado.Commands
{
    public class ResponseCommand 
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
