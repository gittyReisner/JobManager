using JobManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobManager.Data.context
{
    public static class InitialData
    {
        public static void Seed(this ApplicationDbContext dbContext)
        {
            if (!dbContext.Jobs.Any())
            {
                dbContext.Jobs.Add(new Job
                {
                    JobName = "designer",
                    Date = new DateTime(2023,01,30, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "storekeeper",
                    Date = new DateTime(2023, 01, 28, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "analyst",
                    Date = new DateTime(2023, 01, 25, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "researcher",
                    Date = new DateTime(2023, 02, 02, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "teacher",
                    Date = new DateTime(2023, 02, 05, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "real estate agent",
                    Date = new DateTime(2023, 01, 29, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "shift Manager",
                    Date = new DateTime(2023, 02, 19, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "chemical engineer",
                    Date = new DateTime(2023, 02, 01, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "lecturer",
                    Date = new DateTime(2023, 02, 02, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "manager",
                    Date = new DateTime(2023, 01, 26, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "insurance Agent",
                    Date = new DateTime(2023, 01, 01, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "tax Advisor",
                    Date = new DateTime(2023, 01, 25, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "CPA",
                    Date = new DateTime(2023, 01, 26, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "financial advisor",
                    Date = new DateTime(2023, 01, 27, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "chemical engineer",
                    Date = new DateTime(2023, 01, 26, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "architect",
                    Date = new DateTime(2023, 01, 28, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "confectioner",
                    Date = new DateTime(2023, 01, 28, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "painter",
                    Date = new DateTime(2023, 01, 29, 0, 0, 0)
                });
                dbContext.Jobs.Add(new Job
                {
                    JobName = "dressmaker",
                    Date = new DateTime(2023, 01, 30, 0, 0, 0)
                });

                dbContext.SaveChanges();
            }
            if (!dbContext.JobViews.Any())
            {
                dbContext.JobViews.Add(new JobView
                {
                    JobId = 1,
                    Date = new DateTime(2023, 01, 31, 0, 0, 0)
                });
                dbContext.JobViews.Add(new JobView
                {
                    JobId = 1,
                    Date = new DateTime(2023, 01, 30, 0, 0, 0)
                });
                dbContext.JobViews.Add(new JobView
                {
                    JobId = 12,
                    Date = new DateTime(2023, 02, 02, 0, 0, 0)
                });
                dbContext.JobViews.Add(new JobView
                {
                    JobId = 10,
                    Date = new DateTime(2023, 02, 06, 0, 0, 0)
                });
                dbContext.JobViews.Add(new JobView
                {
                    JobId = 11,
                    Date = new DateTime(2023, 02, 07, 0, 0, 0)
                });
                dbContext.JobViews.Add(new JobView
                {
                    JobId = 11,
                    Date = new DateTime(2023, 01, 31, 0, 0, 0)
                });
                dbContext.JobViews.Add(new JobView
                {
                    JobId = 11,
                    Date = new DateTime(2023, 01, 30, 0, 0, 0)
                });
                dbContext.JobViews.Add(new JobView
                {
                    JobId = 10,
                    Date = new DateTime(2023, 01, 07, 0, 0, 0)
                });
                dbContext.JobViews.Add(new JobView
                {
                    JobId = 2,
                    Date = new DateTime(2023, 01, 31, 0, 0, 0)
                });

                dbContext.SaveChanges();
            }


        }
    }
}
