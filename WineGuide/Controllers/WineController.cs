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
        WineItemsProvider wineItemsProvider;

        public WineController(IWine repository)
        {
            _repository = repository;
            wineItemsProvider = new WineItemsProvider(_repository);
        }

        // api/Wine
        [EnableCors("Policy1")]
        [HttpGet]
        public List<WineDataModel> GetWines()
        {
            return wineItemsProvider.GetWines();
        }

        // GET api/<WineController>/5
        [HttpGet("{id}")]
        public WineDataModel GetWineById(int id)
        {
            return wineItemsProvider.GetWineById(id);
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

    }
}

