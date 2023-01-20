using JobManager.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IJobsRepository Jobs { get; }
        Task<int> CommitAsync();
    }
}
