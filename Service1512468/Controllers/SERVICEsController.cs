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
    public class SERVICEsController : ApiController
    {
        private ModelDB db = new ModelDB();

        // GET: api/SERVICEs
        public IQueryable<SERVICE> GetSERVICEs()
        {
            return db.SERVICEs;
        }

        // GET: api/SERVICEs/5
        [ResponseType(typeof(SERVICE))]
        public IHttpActionResult GetSERVICE(int id)
        {
            SERVICE sERVICE = db.SERVICEs.Find(id);
            if (sERVICE == null)
            {
                return NotFound();
            }

            return Ok(sERVICE);
        }

        // PUT: api/SERVICEs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSERVICE(int id, SERVICE sERVICE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sERVICE.ID)
            {
                return BadRequest();
            }

            db.Entry(sERVICE).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SERVICEExists(id))
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

        // POST: api/SERVICEs
        [ResponseType(typeof(SERVICE))]
        public IHttpActionResult PostSERVICE(SERVICE sERVICE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SERVICEs.Add(sERVICE);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sERVICE.ID }, sERVICE);
        }

        // DELETE: api/SERVICEs/5
        [ResponseType(typeof(SERVICE))]
        public IHttpActionResult DeleteSERVICE(int id)
        {
            SERVICE sERVICE = db.SERVICEs.Find(id);
            if (sERVICE == null)
            {
                return NotFound();
            }

            db.SERVICEs.Remove(sERVICE);
            db.SaveChanges();

            return Ok(sERVICE);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SERVICEExists(int id)
        {
            return db.SERVICEs.Count(e => e.ID == id) > 0;
        }
    }
}