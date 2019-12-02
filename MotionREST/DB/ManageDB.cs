using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MotionREST.Controllers;
using MotionREST.Model;

namespace MotionREST.DB
{
    public class ManageDB
    {
        private const string GET_ALL = "select* from Motion";
        public IEnumerable<MotionREST.Model.MotionsModelWorkPlease> Get()
        {

            List<MotionREST.Model.MotionsModelWorkPlease> liste = new List<MotionREST.Model.MotionsModelWorkPlease>();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                using (SqlCommand cmd = new SqlCommand(GET_ALL, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MotionREST.Model.MotionsModelWorkPlease motion = ReadNextElement(reader);
                            liste.Add(motion);
                        }
                    }
                    return liste;


                }
            }

        }
        protected MotionREST.Model.MotionsModelWorkPlease ReadNextElement(SqlDataReader reader)
        {
            MotionREST.Model.MotionsModelWorkPlease mymotion = new MotionREST.Model.MotionsModelWorkPlease();
            mymotion.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
            mymotion.Roll = reader.IsDBNull(1) ? 0 : reader.GetDouble(1);
            mymotion.Yaw = reader.IsDBNull(2) ? 0 : reader.GetDouble(2);
            mymotion.Pitch = reader.IsDBNull(3) ? 0 : reader.GetDouble(3);
            mymotion.MyDataTime = reader.IsDBNull(4) ? DateTime.Parse("1900-11-11T00:00:00.00") : reader.GetDateTime(4);
            mymotion.DeviceId = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
            return mymotion;
        }
    }
}
