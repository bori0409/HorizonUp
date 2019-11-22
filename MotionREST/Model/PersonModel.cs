using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotionREST.Model
{
    public class PersonModel
    {
        public int PersonId;
        public string PersonName
        {
            get;set;
        }
        public int MyMotion
        {
            get; set;

        }
        public PersonModel()
        {
                
        }
        public PersonModel(int id, string name, int motionId)
        {
            id = PersonId;
            name = PersonName;
            motionId = MyMotion;
        }


    }
}
