using App.EcoAprender.Cqrs.Domain.Comunicado.Commands;
using App.EcoAprender.Cqrs.Domain.Comunicado.Queries;
using System.Collections.Generic;

namespace App.EcoAprender.Cqrs.Domain.Comunicado.Interfaces.Repositories
{
    public interface IComunicadoRepository
    {
        IEnumerable<ComunicadoListarResponseQuery> Listar();

        int Adicionar(ComunicadoAdicionarCommand request);
    }
}
