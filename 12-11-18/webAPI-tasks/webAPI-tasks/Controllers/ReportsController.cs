﻿using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace webAPI_tasks.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ReportsController : ApiController
    {
        
        [HttpGet]
        [Route("api/Reports/GetProjectReportData")]
        public HttpResponseMessage GetProjectReportData()
        {
            return Request.CreateResponse(HttpStatusCode.OK, LogicReports.CreateProjectReport());
        }
<<<<<<< HEAD
=======
        [HttpGet]
        [Route("api/Reports/GetWorkerReportData")]
        public HttpResponseMessage GetWorkerReportData()
        {
            return Request.CreateResponse(HttpStatusCode.OK, LogicReports.CreateWorkerReport());
        }
>>>>>>> cefbea1ebe43b7c294cdbb0a1fc2a8aabadfaf2d
    }
}
