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
using System.Web.Script.Serialization;
using apiAppChecador.Models;

namespace apiAppChecador.Controllers
{
    public class REGISTRO_CHECADAController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/REGISTRO_CHECADA
        public IQueryable<REGISTRO_CHECADA> GetREGISTRO_CHECADA()
        {
            return db.REGISTRO_CHECADA;
        }

        // GET: api/REGISTRO_CHECADA/5
        [ResponseType(typeof(REGISTRO_CHECADA))]
        public IHttpActionResult GetREGISTRO_CHECADA(int id)
        {
            REGISTRO_CHECADA rEGISTRO_CHECADA = db.REGISTRO_CHECADA.Find(id);
            if (rEGISTRO_CHECADA == null)
            {
                return NotFound();
            }

            return Ok(rEGISTRO_CHECADA);
        }


        // PUT: api/REGISTRO_CHECADA/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutREGISTRO_CHECADA(int id, REGISTRO_CHECADA rEGISTRO_CHECADA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rEGISTRO_CHECADA.ID)
            {
                return BadRequest();
            }

            db.Entry(rEGISTRO_CHECADA).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!REGISTRO_CHECADAExists(id))
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

        // POST: api/REGISTRO_CHECADA
        [ResponseType(typeof(REGISTRO_CHECADA))]
        public IHttpActionResult PostREGISTRO_CHECADA(REGISTRO_CHECADA rEGISTRO_CHECADA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.REGISTRO_CHECADA.Add(rEGISTRO_CHECADA);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rEGISTRO_CHECADA.ID }, rEGISTRO_CHECADA);
        }

        [ResponseType(typeof(string))]
        public IHttpActionResult PostREGISTRO_CHECADA(string data)
        {
            REGISTRO_CHECADA rEGISTRO_CHECADA = new REGISTRO_CHECADA();
            List<REGISTRO_CHECADA> ListaRegistros = new List<REGISTRO_CHECADA>();

            JavaScriptSerializer js = new JavaScriptSerializer();
            ListaRegistros = js.Deserialize<List<REGISTRO_CHECADA>>(data);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            foreach (var REGISTRO_CHECADAs in ListaRegistros)
            {
                db.REGISTRO_CHECADA.Add(REGISTRO_CHECADAs);

            }
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rEGISTRO_CHECADA.ID }, rEGISTRO_CHECADA);
        }



        // DELETE: api/REGISTRO_CHECADA/5
        [ResponseType(typeof(REGISTRO_CHECADA))]
        public IHttpActionResult DeleteREGISTRO_CHECADA(int id)
        {
            REGISTRO_CHECADA rEGISTRO_CHECADA = db.REGISTRO_CHECADA.Find(id);
            if (rEGISTRO_CHECADA == null)
            {
                return NotFound();
            }

            db.REGISTRO_CHECADA.Remove(rEGISTRO_CHECADA);
            db.SaveChanges();

            return Ok(rEGISTRO_CHECADA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool REGISTRO_CHECADAExists(int id)
        {
            return db.REGISTRO_CHECADA.Count(e => e.ID == id) > 0;
        }
    }
}