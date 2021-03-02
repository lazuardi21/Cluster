using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using Cluster.Models;
using Cluster.Repositories;

namespace WebApplication1.Controllers
{
    public class PythonController : ApiController
    {

		[Route("api/Execute_Python")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER> GetCentroid()
		{
			
		}
	}
}
