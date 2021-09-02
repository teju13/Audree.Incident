using Audree.Incident.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Audree.Incident.Core.Models.Masters
{

    [Table("Customer", Schema = "Master")]
    public class Customer
    {
       

            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string CustomerName { get; set; }
      
    }
    }

