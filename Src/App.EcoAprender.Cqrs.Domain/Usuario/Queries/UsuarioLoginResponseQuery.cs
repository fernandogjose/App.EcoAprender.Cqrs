namespace App.EcoAprender.Cqrs.Domain.Usuario.Queries
{
    public class UsuarioLoginResponseQuery
    {
        public string Nome { get; private set; }

        public string Email { get; private set; }

        public UsuarioLoginResponseQuery(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
