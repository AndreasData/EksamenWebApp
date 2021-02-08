using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EksamenWebApp;

namespace EksamenWebApp.Controllers
{
    public class WorkersController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: api/Workers
        public IQueryable<Worker> GetWorker()
        {
            return db.Worker;
        }

        // GET: api/Workers/5
        [ResponseType(typeof(Worker))]
        public IHttpActionResult GetWorker(int id)
        {
            Worker worker = db.Worker.Find(id);
            if (worker == null)
            {
                return NotFound();
            }

            return Ok(worker);
        }

        // PUT: api/Workers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWorker(int id, Worker worker)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != worker.WorkerId)
            {
                return BadRequest();
            }

            db.Entry(worker).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkerExists(id))
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

        // POST: api/Workers
        [ResponseType(typeof(Worker))]
        public IHttpActionResult PostWorker(Worker worker)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Worker.Add(worker);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = worker.WorkerId }, worker);
        }

        // DELETE: api/Workers/5
        [ResponseType(typeof(Worker))]
        public IHttpActionResult DeleteWorker(int id)
        {
            Worker worker = db.Worker.Find(id);
            if (worker == null)
            {
                return NotFound();
            }

            db.Worker.Remove(worker);
            db.SaveChanges();

            return Ok(worker);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WorkerExists(int id)
        {
            return db.Worker.Count(e => e.WorkerId == id) > 0;
        }
    }
}