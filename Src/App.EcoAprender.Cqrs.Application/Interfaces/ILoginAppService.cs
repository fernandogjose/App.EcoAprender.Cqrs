using App.EcoAprender.Cqrs.Application.ViewModels;

namespace App.EcoAprender.Cqrs.Application.Interfaces
{
    public interface ILoginAppService
    {
        ResponseViewModel Entrar(LoginViewModel request);
    }
}
