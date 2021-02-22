using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cluster.Models
{
    public partial class PL_CUSTOMER_CLUSTER4
    {
        [Display(Name = "datetime")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DATE_STAMP { get; set; }
        public virtual string MONTH { get; set; }
        public virtual int? YEAR { get; set; }
        public virtual string IDREFPELANGGAN { get; set; }
        public virtual string NAMA { get; set; }
        public virtual int? CLUSTER_NUM { get; set; }

        public PL_CUSTOMER_CLUSTER4()
        {

        }
    }
}