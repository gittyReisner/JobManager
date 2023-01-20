using JobManager.Core.Models;
using JobManager.Core.Repositories;
using JobManager.Data.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Data.Repositories
{
    public class JobsRepository : IJobsRepository
    {
        private ApplicationDbContext _appContext;

        public JobsRepository(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }
        public async Task<List<Job>> GetJobsByDateRange(DateTime startDate, DateTime endDate)
        {
            List<Job> jobsList = new List<Job>();
            jobsList = _appContext.Jobs.Where(job => job.Date >= startDate && job.Date <= endDate).ToList();

            if (jobsList != null)
                return jobsList;
            return null;
        }

        public async Task<List<JobView>> GetJobsViewsCountPerDayInDateRange(DateTime startDate, DateTime endDate)
        {
            List<JobView> jobViewsList = new List<JobView>();
            jobViewsList = _appContext.JobViews.Where(view => view.Date >= startDate && view.Date <= endDate).ToList();

            if (jobViewsList != null)
                return jobViewsList;
            return null;
        }

        public async Task<int> GetJobsViewsForSpecificJobs(List<Job> jobs)
        {
            int count = 0;

            List<JobView> jobViews = new List<JobView>();
            foreach (var job in jobs)
            {
                count += _appContext.JobViews.Count(view => job.JobId == view.JobId);
            }
            return count;
        }
    }
}
