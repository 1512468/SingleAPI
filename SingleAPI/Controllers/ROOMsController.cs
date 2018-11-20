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

namespace SingleAPI.Controllers
{
    public class ROOMsController : ApiController
    {
        private ModelDB db = new ModelDB();

        // GET: api/ROOMs
        public IQueryable<ROOM> GetROOMs()
        {
            return db.ROOMs;
        }

        // GET: api/ROOMs/5
        [ResponseType(typeof(ROOM))]
        public IHttpActionResult GetROOM(int id)
        {
            ROOM rOOM = db.ROOMs.Find(id);
            if (rOOM == null)
            {
                return NotFound();
            }

            return Ok(rOOM);
        }

        // PUT: api/ROOMs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutROOM(int id, ROOM rOOM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rOOM.ID)
            {
                return BadRequest();
            }

            db.Entry(rOOM).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ROOMExists(id))
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

        // POST: api/ROOMs
        [ResponseType(typeof(ROOM))]
        public IHttpActionResult PostROOM(ROOM rOOM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ROOMs.Add(rOOM);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rOOM.ID }, rOOM);
        }

        // DELETE: api/ROOMs/5
        [ResponseType(typeof(ROOM))]
        public IHttpActionResult DeleteROOM(int id)
        {
            ROOM rOOM = db.ROOMs.Find(id);
            if (rOOM == null)
            {
                return NotFound();
            }

            db.ROOMs.Remove(rOOM);
            db.SaveChanges();

            return Ok(rOOM);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ROOMExists(int id)
        {
            return db.ROOMs.Count(e => e.ID == id) > 0;
        }
    }
}