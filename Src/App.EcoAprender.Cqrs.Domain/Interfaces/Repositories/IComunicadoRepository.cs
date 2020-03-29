using App.EcoAprender.Cqrs.Domain.Models;
using System.Collections.Generic;

namespace App.EcoAprender.Cqrs.Domain.Interfaces.Repositories
{
    public interface IComunicadoRepository
    {
        IEnumerable<Comunicado> Listar();
    }
}
