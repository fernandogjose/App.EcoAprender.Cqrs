﻿using App.EcoAprender.Cqrs.Domain.Compartilhado.Interfaces.Repositories;
using System;
using System.Data;

namespace App.EcoAprender.Cqrs.Infra.Data.Dapper.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;

        public IDbConnection Connection { get; } = null;

        public IDbTransaction Transaction { get; private set; } = null;

        public UnitOfWork(IDbConnection connection)
        {
            Connection = connection;
            Connection.Open();
        }

        public void BeginTransaction()
        {
            if (Transaction == null)
            {
                Transaction = Connection.BeginTransaction(IsolationLevel.ReadCommitted);
            }
        }

        public void CommitTransaction()
        {
            if (Transaction != null)
            {
                Transaction.Commit();
                Dispose();
            }
        }

        public void RollBack()
        {
            if (Transaction != null)
            {
                Transaction.Rollback();
                Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing && Transaction != null)
            {
                Transaction.Dispose();

                Connection.Close();
                Connection.Dispose();
            }
            disposed = true;
        }
    }
}
