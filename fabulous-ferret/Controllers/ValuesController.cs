using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fabulous_ferret.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/Values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"value {id}";
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] Value value)
        {
            // German 004: Add data validation. 
            if (!ModelState.IsValid)
            {
                throw new InvalidOperationException("Password length is not enough.");
            }
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    // German 003: Add class Value with DataAnnotations on password property.
    public class Value
    {
        public string nombre { get; set; }

        [MinLength(12)]
        public string password { get; set; }
    }
}
