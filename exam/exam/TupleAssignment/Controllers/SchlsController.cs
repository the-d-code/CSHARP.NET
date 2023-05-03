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
using TupleAssignment;

namespace TupleAssignment.Controllers
{
    public class SchlsController : ApiController
    {
        private SchoolEntities db = new SchoolEntities();

        // GET: api/Schls
        public IQueryable<Schl> GetSchls()
        {
            return db.Schls;
        }

        // GET: api/Schls/5
        [ResponseType(typeof(Schl))]
        public IHttpActionResult GetSchl(int id)
        {
            Schl schl = db.Schls.Find(id);
            if (schl == null)
            {
                return NotFound();
            }

            return Ok(schl);
        }

        // PUT: api/Schls/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSchl(int id, Schl schl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != schl.Sid)
            {
                return BadRequest();
            }

            db.Entry(schl).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchlExists(id))
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

        // POST: api/Schls
        [ResponseType(typeof(Schl))]
        public IHttpActionResult PostSchl(Schl schl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Schls.Add(schl);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = schl.Sid }, schl);
        }

        // DELETE: api/Schls/5
        [ResponseType(typeof(Schl))]
        public IHttpActionResult DeleteSchl(int id)
        {
            Schl schl = db.Schls.Find(id);
            if (schl == null)
            {
                return NotFound();
            }

            db.Schls.Remove(schl);
            db.SaveChanges();

            return Ok(schl);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SchlExists(int id)
        {
            return db.Schls.Count(e => e.Sid == id) > 0;
        }
    }
}