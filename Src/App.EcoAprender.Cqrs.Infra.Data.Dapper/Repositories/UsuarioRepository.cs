using App.EcoAprender.Cqrs.Domain.Compartilhado.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Usuario.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Usuario.Queries;
using Dapper;

namespace App.EcoAprender.Cqrs.Infra.Data.Dapper.Repositories
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        public UsuarioRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public UsuarioLoginResponseQuery Login(UsuarioLoginRequestQuery request)
        {
            string sql = @"SELECT Usuario.Name as Nome
                                , Usuario.Email
                           FROM CrmUser AS Usuario(nolock)
                           WHERE Usuario.Email = @Email
                             AND Usuario.Password = @Senha";

            using var connection = _unitOfWork.Connection;
            UsuarioLoginResponseQuery response = connection.QueryFirstOrDefault<UsuarioLoginResponseQuery>(sql, request);
            
            return response;
        }
    }
}
