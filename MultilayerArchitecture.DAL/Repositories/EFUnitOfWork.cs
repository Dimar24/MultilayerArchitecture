//using MultilayerArchitecture.DAL.EF;
//using MultilayerArchitecture.DAL.Entities;
using MultilayerArchitecture.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultilayerArchitecture.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        EFUnitOfWork(string connectString)
        {
            //Initialization db
        }

        public void Save()
        {
            //Save db
        }

        private bool disposed = false;

        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                //Clear db
                //if(disposing) db.Dispose()
                disposed = true;
            }
        }    
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
