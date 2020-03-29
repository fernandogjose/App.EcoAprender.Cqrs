using App.EcoAprender.Cqrs.Domain.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Models;
using Dapper;
using System.Collections.Generic;

namespace App.EcoAprender.Cqrs.Infra.Data.Dapper.Repositories
{
    public class ComunicadoRepository : BaseRepository, IComunicadoRepository
    {
        public ComunicadoRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public IEnumerable<Comunicado> Listar()
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
            IEnumerable<Comunicado> response = connection.Query<Comunicado>(sql);
            
            return response;
        }
    }
}
