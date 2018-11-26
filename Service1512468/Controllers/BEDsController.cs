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
using Domain.package;

namespace Service1512468.Controllers
{
    public class BEDsController : ApiController
    {
        private ModelDB db = new ModelDB();

        // GET: api/BEDs
        public IQueryable<BED> GetBEDs()
        {
            return db.BEDs;
        }

        // GET: api/BEDs/5
        [ResponseType(typeof(BED))]
        public IHttpActionResult GetBED(int id)
        {
            BED bED = db.BEDs.Find(id);
            if (bED == null)
            {
                return NotFound();
            }

            return Ok(bED);
        }

        // PUT: api/BEDs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBED(int id, BED bED)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bED.ID)
            {
                return BadRequest();
            }

            db.Entry(bED).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BEDExists(id))
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

        // POST: api/BEDs
        [ResponseType(typeof(BED))]
        public IHttpActionResult PostBED(BED bED)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.BEDs.Add(bED);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = bED.ID }, bED);
        }

        // DELETE: api/BEDs/5
        [ResponseType(typeof(BED))]
        public IHttpActionResult DeleteBED(int id)
        {
            BED bED = db.BEDs.Find(id);
            if (bED == null)
            {
                return NotFound();
            }

            db.BEDs.Remove(bED);
            db.SaveChanges();

            return Ok(bED);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BEDExists(int id)
        {
            return db.BEDs.Count(e => e.ID == id) > 0;
        }
    }
}