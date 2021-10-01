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
using apiAppChecador.Models;

namespace apiAppChecador.Controllers
{
    public class USUARIOSAPPController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/USUARIOSAPP
        public IQueryable<USUARIOSAPP> GetUSUARIOSAPP()
        {
            return db.USUARIOSAPP;
        }

        // GET: api/USUARIOSAPP/5
        [ResponseType(typeof(USUARIOSAPP))]
        public IHttpActionResult GetUSUARIOSAPP(int id)
        {
            USUARIOSAPP uSUARIOSAPP = db.USUARIOSAPP.Find(id);
            if (uSUARIOSAPP == null)
            {
                return NotFound();
            }

            return Ok(uSUARIOSAPP);
        }

        // GET: api/USUARIOSAPP/5
        [ResponseType(typeof(USUARIOSAPP))]
        public IHttpActionResult GetUSUARIOSAPP(int noEmp,string password)
        {
            USUARIOSAPP uSUARIOSAPP = db.USUARIOSAPP.Where(data => data.NOEMPLEADO == noEmp && data.PASSWORD == password).FirstOrDefault();

            if (uSUARIOSAPP == null)
            {
                uSUARIOSAPP = new USUARIOSAPP();
            }

            return Ok(uSUARIOSAPP);
        }

        // GET: api/USUARIOSAPP/5
        [ResponseType(typeof(USUARIOSAPP))]
        public IHttpActionResult GetUSUARIOSAPPByNoEmp(int noEmp)
        {
            USUARIOSAPP uSUARIOSAPP = db.USUARIOSAPP.Where(data => data.NOEMPLEADO == noEmp).FirstOrDefault();

            if (uSUARIOSAPP == null)
            {
                uSUARIOSAPP = new USUARIOSAPP();
            }

            return Ok(uSUARIOSAPP);
        }


        // PUT: api/USUARIOSAPP/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUSUARIOSAPP(int id, USUARIOSAPP uSUARIOSAPP)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uSUARIOSAPP.ID)
            {
                return BadRequest();
            }

            db.Entry(uSUARIOSAPP).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!USUARIOSAPPExists(id))
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

        // POST: api/USUARIOSAPP
        [ResponseType(typeof(USUARIOSAPP))]
        public IHttpActionResult PostUSUARIOSAPP(USUARIOSAPP uSUARIOSAPP)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.USUARIOSAPP.Add(uSUARIOSAPP);
            //db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = uSUARIOSAPP.ID }, uSUARIOSAPP);
        }

        // DELETE: api/USUARIOSAPP/5
        [ResponseType(typeof(USUARIOSAPP))]
        public IHttpActionResult DeleteUSUARIOSAPP(int id)
        {
            USUARIOSAPP uSUARIOSAPP = db.USUARIOSAPP.Find(id);
            if (uSUARIOSAPP == null)
            {
                return NotFound();
            }

            db.USUARIOSAPP.Remove(uSUARIOSAPP);
            db.SaveChanges();

            return Ok(uSUARIOSAPP);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool USUARIOSAPPExists(int id)
        {
            return db.USUARIOSAPP.Count(e => e.ID == id) > 0;
        }
    }
}