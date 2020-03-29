using App.EcoAprender.Cqrs.Domain.Models;
using System.Collections.Generic;

namespace App.EcoAprender.Cqrs.Domain.Interfaces.Repositories
{
    public interface IAnuncioRepository
    {
        int Adicionar(Anuncio request);

        void Editar(Anuncio request);

        void Deletar(int request);

        Anuncio Obter(Anuncio request);

        IEnumerable<Anuncio> Listar(Anuncio request);
    }
}
