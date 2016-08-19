using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LinqRest.Repositories;
using LinqRest.Models;

namespace LinqRest.Controllers
{
    [Route("api/[controller]")]
    public class BoletasController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Boleta> Get()
        {
            BoletaRepository repo = new BoletaRepository();
            return repo.getAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

