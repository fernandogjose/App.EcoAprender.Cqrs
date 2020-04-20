namespace App.EcoAprender.Cqrs.Application.Compartilhado.ViewModels
{
    public class ResponseViewModel
    {
        public bool Sucesso { get; private set; }

        public string Mensagem { get; set; }

        public object Objeto { get; private set; }

        public ResponseViewModel(bool sucesso, string mensagem, object objeto)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Objeto = objeto;
        }
    }
}
