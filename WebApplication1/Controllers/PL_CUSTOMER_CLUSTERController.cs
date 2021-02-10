using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using Cluster.Models;
using Cluster.Repositories;

namespace Cluster.Controller
{
	public class PL_CUSTOMER_CLUSTERController : ApiController
	{
		private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

		[Route("api/PL_CUSTOMER_CLUSTER")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER> Get()
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER> list = rep.GetData();
			return list.AsQueryable();
		}

		[Route("api/PL_CUSTOMER_CLUSTER_CENTROID")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER> GetCentroid()
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER> list = rep.GetCentroid();
			return list.AsQueryable();
		}

		[Route("api/POPULATION")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER2> GetPopulation()
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER2> list = rep.GetPopulation();
			return list.AsQueryable();
		}

		[Route("api/PL_CUSTOMER_CLUSTER/ID/{id}")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER> GetByID(int id)
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER> list = rep.GetDataByID(id);
			return list.AsQueryable();
		}

		public void Post(PL_CUSTOMER_CLUSTER pl_customer_cluster)
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			rep.Add(pl_customer_cluster);
		}

		public void Put(PL_CUSTOMER_CLUSTER pl_customer_cluster)
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			rep.Update(pl_customer_cluster);
		}

		public void Delete(PL_CUSTOMER_CLUSTER pl_customer_cluster)
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			rep.Remove(pl_customer_cluster);
		}

	}
}