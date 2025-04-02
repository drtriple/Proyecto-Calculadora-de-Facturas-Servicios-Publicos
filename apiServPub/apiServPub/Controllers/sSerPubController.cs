using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiServPub.Models;
using apiServPub.Clases;
using System.Web.Http.Cors;

namespace apiServPub.Controllers
{
    public class sSerPubController : ApiController
    {
        // /api/sSerPub
        [HttpPost]
        [EnableCors(origins: "*", methods: "*", headers: "*")]
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/sSerPub
        [HttpPost]
        [Route("api/sSerPub")]
        public modServPub Post([FromBody] modServPub objlN)
        //public IHttpActionResult Post([FromBody] modServPub objlN)
        {
            clsOpeServPub objOpe = new clsOpeServPub();
            objOpe.pModSP = objlN;
            objOpe.Facturar();
            return objOpe.pModSP;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}