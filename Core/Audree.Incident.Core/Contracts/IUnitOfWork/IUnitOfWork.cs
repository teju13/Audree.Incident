using System;
using System.Collections.Generic;
using System.Text;

namespace Audree.Incident.Core.Contracts.IUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
