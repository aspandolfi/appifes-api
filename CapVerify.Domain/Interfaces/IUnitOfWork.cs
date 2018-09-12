using System;
using System.Collections.Generic;
using System.Text;

namespace CapVerify.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
