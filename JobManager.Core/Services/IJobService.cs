using JobManager.Core.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Core.Services
{
    public interface IJobService
    {
        ManagerResponse<JobsGetDataResponse> GetJobsData(DateTime startDate, DateTime endDate);
    }
}
