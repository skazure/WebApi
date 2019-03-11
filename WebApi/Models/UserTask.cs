using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class UserTask
    {
        public int TaskId { get; set; }
        public string TaskType { get; set; }
        public string AssignedOn { get; set; }
    }
}