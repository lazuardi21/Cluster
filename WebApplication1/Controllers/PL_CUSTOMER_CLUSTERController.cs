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
		
		[Route("api/PL_CUSTOMER_CLUSTER_CENTROID2")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER> GetCentroid2()
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER> list = rep.GetCentroid2();
			return list.AsQueryable();
		}
		
		[Route("api/PL_CUSTOMER_CLUSTER_CENTROID3")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER> GetCentroid3()
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER> list = rep.GetCentroid3();
			return list.AsQueryable();
		}

		[Route("api/GETDATAPELANGGAN")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER> GetDataPelanggan()
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER> list = rep.GetDataPelanggan();
			return list.AsQueryable();
		}

		[Route("api/GETDATAPELANGGAN2")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER4> GetDataPelanggan2()
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER4> list = rep.GetDataPelanggan2();
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

		[Route("api/GMSL")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER3> GetGMSL()
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER3> list = rep.GetGMSL();

			foreach (var data in list)
			{

				for (var i = 0; i < list.Count; i++)
				{
					var a = String.Format("{0:yyyy/mm/dd}", data.DATE_TIME);
					var b = a;
					var c = @Convert.ToString(string.Format("{0:dd/MM/yyyy}", data.DATE_TIME));
					var d = c;

				}

			}
			

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

		[Route("api/PL_CUSTOMER_CLUSTER/cluster/{id}")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER> GetClusterByID(int id)
		{
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER> list = rep.GetClusterByID(id);
			return list.AsQueryable();
		}
		
		[Route("api/PL_CUSTOMER_CLUSTER/date/{DATE}")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER> GetDateByID(DateTime DATE)
		{
			DATE = Convert.ToDateTime(DATE);
			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER> list = rep.GetDateByID(DATE);
			return list.AsQueryable();
		}

		[Route("api/GetCustomer/all/{id}/{MONTH}/{YEAR}")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER> GetCustomer(int id, string MONTH, int YEAR)
		{

			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER> list = rep.GetCustomer(id, MONTH, YEAR);
			return list.AsQueryable();
		}
		
		[Route("api/GetCustomerData/all/{id}/{MONTH}/{YEAR}")]
		[HttpGet]
		public IQueryable<PL_CUSTOMER_CLUSTER> GetCustomerData(int id, string MONTH, int YEAR)
		{

			PL_CUSTOMER_CLUSTERRepository rep = new PL_CUSTOMER_CLUSTERRepository(connectionString);
			List<PL_CUSTOMER_CLUSTER> list = rep.GetCustomerData(id, MONTH, YEAR);
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