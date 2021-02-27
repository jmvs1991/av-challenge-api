using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using av_challenge_api.Pais.Services;
using Connection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace av_challenge_api.Pais.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {

        private readonly PaisService _paisService;

        public PaisController(ApiContext context)
        {

            _paisService = new PaisService(context);

        }

        // GET: api/<PaisController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PaisController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PaisController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PaisController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PaisController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
