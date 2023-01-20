using JobManager.Core;
using JobManager.Core.Repositories;
using JobManager.Data.context;
using JobManager.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private JobsRepository _jobsRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IJobsRepository Jobs => _jobsRepository = _jobsRepository ?? new JobsRepository(_context);


        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
