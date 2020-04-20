using App.EcoAprender.Cqrs.Application.Compartilhado.ViewModels;
using App.EcoAprender.Cqrs.Application.Usuario.ViewModels;

namespace App.EcoAprender.Cqrs.Application.Usuario.Interfaces
{
    public interface IUsuarioAppService
    {
        ResponseViewModel Login(UsuarioLoginRequestViewModel request);
    }
}
