using App.EcoAprender.Cqrs.Domain.Interfaces.Repositories;
using App.EcoAprender.Cqrs.Domain.Models;
using Dapper;

namespace App.EcoAprender.Cqrs.Infra.Data.Dapper.Repositories
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        public UsuarioRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public Usuario Login(Usuario request)
        {
            string sql = @"SELECT Usuario.Name as Nome
                                , Usuario.Email
                           FROM CrmUser AS Usuario(nolock)
                           WHERE Usuario.Email = @Email
                             AND Usuario.Password = @Senha";

            using var connection = _unitOfWork.Connection;
            Usuario response = connection.QueryFirstOrDefault<Usuario>(sql, request);
            
            return response;
        }
    }
}
