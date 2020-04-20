namespace App.EcoAprender.Cqrs.Domain.Usuario.Queries
{
    public class UsuarioLoginRequestQuery
    {
        public string Senha { get; private set; }

        public string Email { get; private set; }

        public UsuarioLoginRequestQuery(string senha, string email)
        {
            Senha = senha;
            Email = email;
        }
    }
}
