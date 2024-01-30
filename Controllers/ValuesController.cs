using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nogtstapi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace nogtstapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        //PUT api/<ValuesController>/5
        [HttpPut]
        public void Put([FromBody] Customer value)
        {
            using (var db = new nogdbContext())
            {
                var customers = db.Set<Customer>();
                customers.Add(value);
                db.SaveChanges();
            }

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
