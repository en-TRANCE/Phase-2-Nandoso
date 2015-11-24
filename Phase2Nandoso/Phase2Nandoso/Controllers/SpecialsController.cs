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
using Phase2Nandoso.Models;

namespace Phase2Nandoso.Controllers
{
    public class SpecialsController : ApiController
    {
        private Phase2NandosoContext db = new Phase2NandosoContext();

        // GET: api/Specials
        public IQueryable<Specials> GetSpecials()
        {
            return db.Specials;
        }

        // GET: api/Specials/5
        [ResponseType(typeof(Specials))]
        public IHttpActionResult GetSpecials(int id)
        {
            Specials specials = db.Specials.Find(id);
            if (specials == null)
            {
                return NotFound();
            }

            return Ok(specials);
        }

        // PUT: api/Specials/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSpecials(int id, Specials specials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != specials.SpecialsID)
            {
                return BadRequest();
            }

            db.Entry(specials).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecialsExists(id))
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

        // POST: api/Specials
        [ResponseType(typeof(Specials))]
        public IHttpActionResult PostSpecials(Specials specials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Specials.Add(specials);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = specials.SpecialsID }, specials);
        }

        // DELETE: api/Specials/5
        [ResponseType(typeof(Specials))]
        public IHttpActionResult DeleteSpecials(int id)
        {
            Specials specials = db.Specials.Find(id);
            if (specials == null)
            {
                return NotFound();
            }

            db.Specials.Remove(specials);
            db.SaveChanges();

            return Ok(specials);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SpecialsExists(int id)
        {
            return db.Specials.Count(e => e.SpecialsID == id) > 0;
        }
    }
}