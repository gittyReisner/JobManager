using JobManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Core.Repositories
{
    public interface IJobsRepository
    {
        Task<List<Job>> GetJobsByDateRange(DateTime startDate, DateTime endDate);
        Task<List<JobView>> GetJobsViewsCountPerDayInDateRange(DateTime startDate, DateTime endDate);
        Task<int> GetJobsViewsForSpecificJobs(List<Job> jobs);
    }
}
