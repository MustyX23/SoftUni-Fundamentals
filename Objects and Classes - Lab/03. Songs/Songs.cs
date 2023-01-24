using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Songs
{
    public class Song
    {
        //Constructor Create
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        //-------------------------------

        //Properties of Song Class
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }


}
