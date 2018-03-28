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
using XamarinWebService;

namespace XamarinWebService.Controllers
{
    [RoutePrefix("api/usuarios")]
    public class usuariosController : ApiController
    {
        private databaseXamarinEntities db = new databaseXamarinEntities();

        // GET: api/usuarios
        

        // GET: api/usuarios/5
        [HttpGet]
        [Route("isUser/{user:alpha}/{pass:alpha}")]
        public IHttpActionResult Getusuario(string user, string pass)
        {
           
           usuario usuario = db.usuarios.FirstOrDefault(a=> a.usuario1 == user && a.contrasena == pass);
          
            if (usuario == null)
            {
               
                return NotFound();
            }
           
            return Ok();
        }

        // PUT: api/usuarios/5

        [ResponseType(typeof(void))]
        public IHttpActionResult Putusuario(string id, usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usuario.usuario1)
            {
                return BadRequest();
            }

            db.Entry(usuario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!usuarioExists(id))
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

        // POST: api/usuarios
        [HttpPost]
        [ResponseType(typeof(usuario))]
        public IHttpActionResult Postusuario(usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.usuarios.Add(usuario);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (usuarioExists(usuario.usuario1))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = usuario.usuario1 }, usuario);
        }

        // DELETE: api/usuarios/5
        [ResponseType(typeof(usuario))]
        public IHttpActionResult Deleteusuario(string id)
        {
            usuario usuario = db.usuarios.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }

            db.usuarios.Remove(usuario);
            db.SaveChanges();

            return Ok(usuario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool usuarioExists(string id)
        {
            return db.usuarios.Count(e => e.usuario1 == id) > 0;
        }
    }
}