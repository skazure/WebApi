using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReminderController : ApiController
    {

        private Reminder[] reminders = new Reminder[] {
                                new Reminder { RequestId = 1, ReminderType = "Approval", ExpiringOn = "01.01.2020"},
                                new Reminder { RequestId = 2, ReminderType = "Change Request", ExpiringOn = "01.01.2020"},
                                new Reminder { RequestId = 3, ReminderType = "Implementation", ExpiringOn ="01.01.2020"},
                                new Reminder { RequestId = 4, ReminderType = "Expiring",  ExpiringOn = "01.01.2020"},
                                new Reminder { RequestId = 5, ReminderType = "Renewal",  ExpiringOn = "01.01.2020"} };

        // GET: api/Reminder
        [ResponseType(typeof(IEnumerable<Reminder>))]
        public IEnumerable<Reminder> Get()
        {
            return reminders;
        }

        // GET: api/Reminder/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Reminder
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Reminder/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Reminder/5
        public void Delete(int id)
        {
        }
    }
}
