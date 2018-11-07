using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterFromJson
{
    //Получение информации формата JSON
    public class Cities
    {

        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class Geoname
        {
            public string cl { get; set; }
            public string code { get; set; }
            public float parent { get; set; }
        }

        public class Lang
        {
            public string en { get; set; }
            public string ru { get; set; }
        }

        public class Stat
        {
            public double level { get; set; }
            public float population { get; set; }
        }

        public class Station
        {
            public long id { get; set; }
            public int dist { get; set; }
            public int kf { get; set; }
        }

        public class RootObject
        {
            public long id { get; set; }
            public Coord coord { get; set; }
            public string country { get; set; }
            public Geoname geoname { get; set; }
            public List<Lang> langs { get; set; }
            public string name { get; set; }
            public Stat stat { get; set; }
            public List<Station> stations { get; set; }
            public float zoom { get; set; }
        }


    }
}
