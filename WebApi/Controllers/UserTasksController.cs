using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200,http://localhost:4201,http://localhost:9877", headers: "*", methods: "*")]
    public class UserTasksController : ApiController
    {
        private DashboardApiEntities db = new DashboardApiEntities();

        // GET: api/UserTasks
        public IQueryable<UserTask> GetUserTasks()
        {
            return db.UserTasks;
        }

        // GET: api/UserTasks/5
        [ResponseType(typeof(UserTask))]
        public IHttpActionResult GetUserTask(int id)
        {
            UserTask userTask = db.UserTasks.Find(id);
            if (userTask == null)
            {
                return NotFound();
            }

            return Ok(userTask);
        }

        // PUT: api/UserTasks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUserTask(int id, UserTask userTask)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userTask.TaskId)
            {
                return BadRequest();
            }

            db.Entry(userTask).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserTaskExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/UserTasks
        [ResponseType(typeof(UserTask))]
        public IHttpActionResult PostUserTask(UserTask userTask)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UserTasks.Add(userTask);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (UserTaskExists(userTask.TaskId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = userTask.TaskId }, userTask);
        }

        // DELETE: api/UserTasks/5
        [ResponseType(typeof(UserTask))]
        public IHttpActionResult DeleteUserTask(int id)
        {
            UserTask userTask = db.UserTasks.Find(id);
            if (userTask == null)
            {
                return NotFound();
            }

            db.UserTasks.Remove(userTask);
            db.SaveChanges();

            return Ok(userTask);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserTaskExists(int id)
        {
            return db.UserTasks.Count(e => e.TaskId == id) > 0;
        }
    }
}