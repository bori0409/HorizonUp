using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MotionREST.Model;

namespace MotionREST.DB
{
    public class ManageDB
    {
        public IEnumerable<Items> Get()
        {

            List<MotionREST.Model.> liste = new List<Items>();
            using (SqlConnection conn = new SqlConnection(DBstring))
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
                            Items item = ReadNextElement(reader);
                            liste.Add(item);
                        }
                    }
                    return liste;


                }
            }

        }
        protected Items ReadNextElement(SqlDataReader reader)
        {
            Items item = new Items();
            item.Id = reader.GetInt32(0);
            item.Name = reader.GetString(1);
            item.Quality = reader.GetString(2);
            item.Quantity = reader.GetDouble(3);
            return item;
        }
    }
}
