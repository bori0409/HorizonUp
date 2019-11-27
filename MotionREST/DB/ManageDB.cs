using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MotionREST.Model;

namespace MotionREST.DB
{
    public class ManageDB
    {
        private const string GET_ALL = "select* from Motion";
        public IEnumerable<MotionREST.Model.MotionsModelWorkPlease> Get()
        {

            List<MotionREST.Model.MotionsModelWorkPlease> liste = new List<MotionREST.Model.MotionsModelWorkPlease>();
            using (SqlConnection conn = new SqlConnection(Controllers.connectionString.connectionstring))
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
            mymotion.MyDataTime= reader.GetDateTime(0);
            mymotion.Pitch = reader.GetDecimal(1);
            mymotion.Roll = reader.GetDecimal(2);
            mymotion.Yaw = reader.GetDecimal(3);
            return mymotion;
        }
    }
}
