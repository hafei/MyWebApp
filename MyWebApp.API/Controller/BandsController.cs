using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.API.Model;

namespace MyWebApp.API.Controller
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BandsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Band> Get()
        {
            return SimpleData.GetBonds();
        }

        public Band Get(int id)
        {
            var data = SimpleData.GetBonds().Where(o => o.Id.Equals(id));
            if (data.Any())
            {
                return data.First();
            }

            return null;
        }

        // POST api/v1/bands
        [HttpPost]
        public IActionResult Post([FromBody]CreateBandDto band)
        {
            //Call a method to add a new record to the entity
            return Ok();
        }

        // PUT api/v1/bands/7
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]UpdateBandDto band)
        {
            //Call a method to update the entity
            return Ok();
        }

        // DELETE api/bands/7
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Call a method to delete an entity
            return Ok();
        }
    }
}