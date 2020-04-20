using App.EcoAprender.Cqrs.Domain.Compartilhado.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Comunicado.Commands;
using App.EcoAprender.Cqrs.Domain.Comunicado.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Comunicado.Queries;
using Dapper;
using System.Collections.Generic;

namespace App.EcoAprender.Cqrs.Infra.Data.Dapper.Repositories
{
    public class ComunicadoRepository : BaseRepository, IComunicadoRepository
    {
        public ComunicadoRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public int Adicionar(ComunicadoAdicionarCommand request)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ComunicadoListarResponseQuery> Listar()
        {
            string sql = @"SELECT Comunicado.Id
                                , Comunicado.CreateDate AS Data
                                , Comunicado.Title AS Titulo
                                , Comunicado.Description AS Descricao
	                            , Grupo.Description AS Grupo
                           FROM CrmComunication AS Comunicado(nolock)
                           INNER JOIN CrmGroup AS Grupo on Comunicado.GroupId = Grupo.Id
                           WHERE Comunicado.SchoolId = 1";

            using var connection = _unitOfWork.Connection;
            IEnumerable<ComunicadoListarResponseQuery> response = connection.Query<ComunicadoListarResponseQuery>(sql);
            
            return response;
        }
    }
}
