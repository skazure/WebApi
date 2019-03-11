using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Reminder { 

    public int RequestId { get; set; }
    public string ReminderType { get; set; }
    public string ExpiringOn { get; set; }
}
}