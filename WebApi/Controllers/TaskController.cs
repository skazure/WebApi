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
    public class TaskController : ApiController
    {

        private UserTask[] usertasks = new UserTask[] {
                                new UserTask { TaskId = 1, TaskType = "Approval", AssignedOn = "01.01.2020"},
                                new UserTask { TaskId = 2, TaskType = "Submit", AssignedOn = "01.01.2020"},
                                new UserTask { TaskId = 3, TaskType = "Approval", AssignedOn ="01.01.2020"},
                                new UserTask { TaskId = 4, TaskType = "Expiring",  AssignedOn = "01.01.2020"},
                                new UserTask { TaskId = 5, TaskType = "Submit",  AssignedOn = "01.01.2020"} };


        // GET: api/Task
        [ResponseType(typeof(IEnumerable<UserTask>))]
        public IEnumerable<UserTask> Get()
        {
            return usertasks;
        }

        // GET: api/Task/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Task
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Task/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Task/5
        public void Delete(int id)
        {
        }
    }
}
