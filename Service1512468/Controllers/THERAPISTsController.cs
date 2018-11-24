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
    public class THERAPISTsController : ApiController
    {
        private ModelDB db = new ModelDB();

        // GET: api/THERAPISTs
        public IQueryable<THERAPIST> GetTHERAPISTs()
        {
            return db.THERAPISTs;
        }

        // GET: api/THERAPISTs/5
        [ResponseType(typeof(THERAPIST))]
        public IHttpActionResult GetTHERAPIST(int id)
        {
            THERAPIST tHERAPIST = db.THERAPISTs.Find(id);
            if (tHERAPIST == null)
            {
                return NotFound();
            }

            return Ok(tHERAPIST);
        }

        // PUT: api/THERAPISTs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTHERAPIST(int id, THERAPIST tHERAPIST)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tHERAPIST.ID)
            {
                return BadRequest();
            }

            db.Entry(tHERAPIST).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!THERAPISTExists(id))
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

        // POST: api/THERAPISTs
        [ResponseType(typeof(THERAPIST))]
        public IHttpActionResult PostTHERAPIST(THERAPIST tHERAPIST)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.THERAPISTs.Add(tHERAPIST);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tHERAPIST.ID }, tHERAPIST);
        }

        // DELETE: api/THERAPISTs/5
        [ResponseType(typeof(THERAPIST))]
        public IHttpActionResult DeleteTHERAPIST(int id)
        {
            THERAPIST tHERAPIST = db.THERAPISTs.Find(id);
            if (tHERAPIST == null)
            {
                return NotFound();
            }

            db.THERAPISTs.Remove(tHERAPIST);
            db.SaveChanges();

            return Ok(tHERAPIST);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool THERAPISTExists(int id)
        {
            return db.THERAPISTs.Count(e => e.ID == id) > 0;
        }
    }
}