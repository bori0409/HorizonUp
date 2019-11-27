using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotionREST.Model
{
    public class MotionsModelWorkPlease
    {
       
        public decimal Pitch
            {
                get; set;
            }
            public decimal Roll
            {
                get; set;
            }
            public decimal Yaw { get; set; }
            public DateTime MyDataTime { get; set; }

            public MotionsModelWorkPlease()
            {

            }
            public MotionsModelWorkPlease(decimal roll, decimal yaw, decimal pitch, DateTime dateTime)
            {
                Roll = roll;
                Pitch = pitch;
                Yaw = yaw;
                MyDataTime = dateTime;
            }

        }
    }

