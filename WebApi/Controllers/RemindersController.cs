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
    public class RemindersController : ApiController
    {
        private DashboardApiEntities db = new DashboardApiEntities();

        // GET: api/Reminders
        public IQueryable<Reminder> GetReminders()
        {
            return db.Reminders;
        }

        // GET: api/Reminders/5
        [ResponseType(typeof(Reminder))]
        public IHttpActionResult GetReminder(int id)
        {
            Reminder reminder = db.Reminders.Find(id);
            if (reminder == null)
            {
                return NotFound();
            }

            return Ok(reminder);
        }

        // PUT: api/Reminders/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReminder(int id, Reminder reminder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != reminder.RequestId)
            {
                return BadRequest();
            }

            db.Entry(reminder).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReminderExists(id))
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

        // POST: api/Reminders
        [ResponseType(typeof(Reminder))]
        public IHttpActionResult PostReminder(Reminder reminder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Reminders.Add(reminder);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ReminderExists(reminder.RequestId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = reminder.RequestId }, reminder);
        }

        // DELETE: api/Reminders/5
        [ResponseType(typeof(Reminder))]
        public IHttpActionResult DeleteReminder(int id)
        {
            Reminder reminder = db.Reminders.Find(id);
            if (reminder == null)
            {
                return NotFound();
            }

            db.Reminders.Remove(reminder);
            db.SaveChanges();

            return Ok(reminder);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReminderExists(int id)
        {
            return db.Reminders.Count(e => e.RequestId == id) > 0;
        }
    }
}