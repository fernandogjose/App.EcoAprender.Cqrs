using App.EcoAprender.Cqrs.Domain.Compartilhado.Interfaces.Repositories;
using System;

namespace App.EcoAprender.Cqrs.Infra.Data.Dapper.Repositories
{
    public abstract class BaseRepository : IDisposable
    {
        protected readonly string _connectionString;
        protected readonly IUnitOfWork _unitOfWork;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            if (_unitOfWork != null)
            {
                _unitOfWork.Connection.Close();
                _unitOfWork.Connection.Dispose();
            }
        }
    }
}