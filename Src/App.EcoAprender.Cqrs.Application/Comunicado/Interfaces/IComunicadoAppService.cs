using App.EcoAprender.Cqrs.Application.Compartilhado.ViewModels;
using App.EcoAprender.Cqrs.Application.Comunicado.ViewModels;
using System.Threading.Tasks;

namespace App.EcoAprender.Cqrs.Application.Comunicado.Interfaces
{
    public interface IComunicadoAppService
    {
        ResponseViewModel Listar();

        Task<ResponseViewModel> Adicionar(ComunicadoAdicionarRequestViewModel request);
    }
}
