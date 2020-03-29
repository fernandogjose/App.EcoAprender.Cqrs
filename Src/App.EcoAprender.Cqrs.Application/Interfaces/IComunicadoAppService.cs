using App.EcoAprender.Cqrs.Application.ViewModels;

namespace App.EcoAprender.Cqrs.Application.Interfaces
{
    public interface IComunicadoAppService
    {
        ResponseViewModel Listar();
    }
}
