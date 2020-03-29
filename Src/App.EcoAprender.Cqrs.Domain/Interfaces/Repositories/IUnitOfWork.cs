using System;
using System.Data;

namespace App.EcoAprender.Cqrs.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();

        void CommitTransaction();

        void RollBack();

        IDbConnection Connection { get; }

        IDbTransaction Transaction { get; }
    }
}
