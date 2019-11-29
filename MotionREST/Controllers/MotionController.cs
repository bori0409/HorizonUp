using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MotionREST.Controllers
{
    [Route("api/motion")]
    [ApiController]
    public class MotionController : ControllerBase
    {
       
        // GET: api/Motion
        DB.ManageDB dbneshto = new DB.ManageDB();
        [HttpGet]
        public IEnumerable<Model.MotionsModelWorkPlease> Get()
        {
            return dbneshto.Get();

        }

        // GET: api/Motion/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Motion
        [HttpPost]
        public void Post([FromBody] Model.MotionsModelWorkPlease value)
        {
           

        }

        // PUT: api/Motion/5
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
}
