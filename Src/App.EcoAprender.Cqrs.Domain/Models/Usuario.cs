namespace App.EcoAprender.Cqrs.Domain.Models
{
    public class Usuario
    {
        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Senha { get; private set; }

        public void PreencherLogin(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}
