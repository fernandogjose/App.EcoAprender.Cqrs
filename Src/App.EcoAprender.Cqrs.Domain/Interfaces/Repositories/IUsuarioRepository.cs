using App.EcoAprender.Cqrs.Domain.Models;

namespace App.EcoAprender.Cqrs.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario Login(Usuario request);
    }
}
