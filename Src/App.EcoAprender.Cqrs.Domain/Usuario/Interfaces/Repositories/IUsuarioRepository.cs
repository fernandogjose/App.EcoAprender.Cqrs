using App.EcoAprender.Cqrs.Domain.Usuario.Queries;

namespace App.EcoAprender.Cqrs.Domain.Usuario.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        UsuarioLoginResponseQuery Login(UsuarioLoginRequestQuery request);
    }
}
