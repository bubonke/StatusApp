using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StatusApp.Models
{
    public class ApplicationStatus
    {
        [Key]
        public string StatusID { get; set; }
        public string Pending { get; set; }
        public string Approved { get; set; }
        public string Reject { get; set; }
    }
}