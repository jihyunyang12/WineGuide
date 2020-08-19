using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WineProvider;
using WineProvider.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WineGuide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WineController : ControllerBase
    {
        private readonly IWine _repository;

        public WineController(IWine repository)
        {
            _repository = repository;
        }

        // GET: api/<WineController>

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WineController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WineController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WineController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WineController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // api/Wine/wine
        [EnableCors("Policy1")]
        [HttpGet("wine")]
        public List<WineDataModel> GetWines()
        {
            WineItemsProvider wineItemsProvider = new WineItemsProvider(_repository);
            return wineItemsProvider.GetWines();
        }

    }
}

