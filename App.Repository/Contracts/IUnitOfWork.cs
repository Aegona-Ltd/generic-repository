using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        Task Commit();
    }
}
