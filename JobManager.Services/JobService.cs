using JobManager.Core;
using JobManager.Core.Models;
using JobManager.Core.Response;
using JobManager.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobManager.Services
{
    public class JobService : IJobService
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ManagerResponse<JobsGetDataResponse> GetJobsData(DateTime startDate, DateTime endDate)
        {
            var isValid = validate(startDate, endDate, out string errorMsg);
            if (false == isValid)
            {
                return new ManagerResponse<JobsGetDataResponse>(ManagerResponseResult.DataError, errorMsg);
            }
            var jobsResponse = _unitOfWork.Jobs.GetJobsByDateRange(startDate, endDate);
            Dictionary<DateTime, List<Job>> jobsDictionary = jobsResponse.Result.GroupBy(j => j.Date).ToDictionary(j => j.Key, j => j.ToList());
            var jobsViewsResponse = _unitOfWork.Jobs.GetJobsViewsCountPerDayInDateRange(startDate, endDate);
            Dictionary<DateTime, int> jobsViewsDictionary = jobsViewsResponse.Result.GroupBy(j => j.Date).ToDictionary(j => j.Key, j => j.Count());

            var response = new JobsGetDataResponse()
            {
                JobsPerDay = new Dictionary<DateTime, int>(),
                JobViews = new Dictionary<DateTime, int>(),
                JobsViewsPerDay = new Dictionary<DateTime, int>(),
                Labels = new List<string>(),
            };

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                response.Labels.Add(date.ToString("dd/MM/yyyy"));
                if (jobsDictionary.ContainsKey(date))
                {
                    response.JobsPerDay.Add(date, jobsDictionary[date].Count);
                    var ViewsForJobsThisDay = _unitOfWork.Jobs.GetJobsViewsForSpecificJobs(jobsDictionary[date]);
                    response.JobViews.Add(date, ViewsForJobsThisDay.Result);
                }
                else
                {
                    response.JobsPerDay.Add(date, 0);
                    response.JobViews.Add(date, 0);
                }

                var countJobsViewsPerDay = jobsViewsDictionary.ContainsKey(date) ? jobsViewsDictionary[date] : 0;
                response.JobsViewsPerDay.Add(date, countJobsViewsPerDay);

            }
            return new ManagerResponse<JobsGetDataResponse>(ManagerResponseResult.Ok, response);
        }

        private bool validate(DateTime startDate, DateTime endDate, out string errorMsg)
        {
            errorMsg = string.Empty;
            if (startDate == null)
            {
                errorMsg = "חובה להזין תאריך התחלה";
                return false;
            }
            if (endDate == null)
            {
                errorMsg = "חובה להזין תאריך התחלה";
                return false;
            }
            if (startDate > endDate)
            {
                errorMsg = "תאריך התחלה גדול מתאריך סיום";
                return false;
            }
            return true;
        }

    }
}
