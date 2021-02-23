using LoanApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanAppController : ControllerBase
    {
        private readonly ILogger<LoanAppController> logger;

        public LoanAppController(ILogger<LoanAppController> logger)
        {
            this.logger = logger;
        }

        // GET: api/<LoanAppController>
        [HttpGet]
        public IEnumerable<LoanAppData> Get()
        {
            var appdata = new LoanAppData();
            yield return appdata;
        }


        // GET api/<LoanAppController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoanAppController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoanAppController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoanAppController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
