using System;
using System.Collections.Generic;
using System.Text;

namespace JobManager.Core.Response
{
    public class JobsGetDataResponse
    {
        public List<string> Labels { get; set; }

        public Dictionary<DateTime, int> JobsPerDay { get; set; }

        public Dictionary<DateTime, int> JobViews { get; set; }

        public Dictionary<DateTime, int> JobsViewsPerDay { get; set; }

    }
}
