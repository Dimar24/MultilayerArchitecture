using System;
using System.Collections.Generic;
using System.Text;

namespace MultilayerArchitecture.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Add Repository
        void Save();
    }
}
