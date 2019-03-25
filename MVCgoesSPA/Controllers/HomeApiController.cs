using MVCgoesSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCgoesSPA.Controllers
{
    public class HomeApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Spa> Get()
        {
            return new Repository().GetAllSpas();
        }

        // GET api/<controller>/5
        public Spa Get(int id)
        {
            return new Repository().GetAllSpas().Skip(id - 1).First();
        }

        // POST api/<controller>
        public void Post([FromBody]Spa value)
        {
            throw new NotImplementedException();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Spa value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}