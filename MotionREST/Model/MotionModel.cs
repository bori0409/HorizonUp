using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotionREST.Motion
{
    public class MotionModel
    {
        public decimal Pitch
        {
            get;set;
        }
        public decimal Roll
        {
            get;set;
        }
        public decimal Yaw { get; set; }
        public DateTime MyDataTime { get; set; }

        public MotionModel()
        {

        }
        public MotionModel(decimal roll, decimal yaw, decimal pitch, DateTime dateTime)
        {
            Roll = roll;
            Pitch = pitch;
            Yaw = yaw;
            MyDataTime = dateTime;
        }

    }
}
