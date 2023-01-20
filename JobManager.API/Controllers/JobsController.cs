using System;
using JobManager.Core.Response;
using JobManager.Core.Services;
using JobManager.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JobManager.API.Controllers
{
    [ApiController]
    public class JobsController : ControllerBase
    {

        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }


        [Route("/api/Jobs")]
        [HttpGet]
        public ActionResult Get(DateTime startDate, DateTime endDate)
        {
            ManagerResponse<JobsGetDataResponse> result = _jobService.GetJobsData(startDate, endDate);
            if (result.Result != ManagerResponseResult.Ok)
            {
                return BadRequest(result.ErrorMessage);
            }

            return new JsonResult(JsonConvert.SerializeObject(result));
        }

    }
}