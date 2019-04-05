using System;
using System.Collections.Generic;
using System.Text;

namespace RestFulWebService.Models
{
    public class CityModel
    {
        public int id { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public Geoname geoname { get; set; }
        public string name { get; set; }
        public Stat stat { get; set; }
        public List<Station> stations { get; set; }
        public int zoom { get; set; }
    }


    public class Geoname
    {
        public string cl { get; set; }
        public string code { get; set; }
        public int parent { get; set; }
    }

    public class Stat
    {
        public double level { get; set; }
        public int population { get; set; }
    }

    public class Station
    {
        public int id { get; set; }
        public int dist { get; set; }
        public int kf { get; set; }
    }
}
