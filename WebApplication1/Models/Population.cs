using System;
using System.Collections.Generic;

namespace Cluster.Models
{
	public partial class PL_CUSTOMER_CLUSTER2
	{
		public virtual int? CityID { get; set; }
		public virtual string CityName { get; set; }
		public virtual int? Population { get; set; }
		

		public PL_CUSTOMER_CLUSTER2()
		{

		}
	}
}