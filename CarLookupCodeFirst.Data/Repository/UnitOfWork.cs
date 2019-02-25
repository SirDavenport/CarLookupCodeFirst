using CarLookupCodeFirst.Data.DAL.Interfaces;
using CarLookupCodeFirst.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLookupCodeFirst.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICarLookupContext _db;
        private bool _disposed = false;

        public UnitOfWork(ICarLookupContext db)
        {
            _db = db;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
