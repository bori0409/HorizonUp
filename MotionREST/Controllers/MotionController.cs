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
        //private static readonly List<MotionModel> motions = new List<MotionModel>()
        //{
        //    new MotionModel(20,25,40,DateTime.Now),
        //    new MotionModel(50,55,120,DateTime.Now),
        //    new MotionModel(120,225,340,DateTime.Now),
        //};
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
           // motions.Add(value);
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
