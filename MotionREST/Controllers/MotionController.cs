using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public int Post([FromBody] Model.MotionsModelWorkPlease value)
        {
            string insertString = "insert into Motion (MotionId,Roll, Yaw, Pitch, MyDateTime,DeviceId) values(@thisid, @thisroll, @thisyaw, @thisPitch, @thisMydateTime, @thisdeviceUD); ";
            using (SqlConnection conn = new SqlConnection(Controllers.ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(insertString, conn))
                {
                    command.Parameters.AddWithValue("@thisid", value.Id);
                    command.Parameters.AddWithValue("@thisroll", value.Roll);
                    command.Parameters.AddWithValue("@thisyaw", value.Yaw);
                    command.Parameters.AddWithValue("@thisPitch", value.Pitch);
                    command.Parameters.AddWithValue("@thisMydateTime", value.MyDataTime);
                    command.Parameters.AddWithValue("@thisdeviceUD", value.DeviceId);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
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
