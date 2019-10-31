using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using For_Project.Models;

namespace For_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Logic logic = new Logic();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<X>> Get()
        {
            return new ObjectResult(logic.Get());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (logic.Get(id) == null)
                return NotFound();
            return new ObjectResult(logic.Get(id));
        }

        // POST api/values
        [HttpPost]
        public int Post([FromBody] X x)
        {
            return logic.Post(x);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            if (value == null)
                return BadRequest();
            if (!logic.Put(id, value))
                return NotFound();
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!logic.Delete(id))
                return NotFound();
            return Ok();
        }
    }
}
