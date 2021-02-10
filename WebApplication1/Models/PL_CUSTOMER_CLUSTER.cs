using System;
using System.Collections.Generic;

namespace Cluster.Models
{
	public partial class PL_CUSTOMER_CLUSTER
	{
		public virtual int? ID { get; set; }
		public virtual DateTime? DATE_STAMP { get; set; }
		public virtual string IDREFPELANGGAN { get; set; }
		public virtual int? HOUR_NUM { get; set; }
		public virtual int? CLUSTER_NUM { get; set; }
		public virtual double? FDVC_NORMALIZED { get; set; }

		public PL_CUSTOMER_CLUSTER()
		{

		}
	}
}