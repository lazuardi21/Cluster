using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cluster.Models
{
	public partial class PL_CUSTOMER_CLUSTER3
	{
		public virtual int? ID { get; set; }

		[Display(Name = "DATE_TIME")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public virtual DateTime? DATE_TIME { get; set; }
		public virtual float? OP { get; set; }
		public virtual float? CL { get; set; }
		

		public PL_CUSTOMER_CLUSTER3()
		{

		}

		
	}

}