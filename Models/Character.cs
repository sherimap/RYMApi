using System;
using System.Collections.Generic;

namespace RYMApi.Models
{
   
    public class Origin
    {
        public required string name { get; set; }
        public required string url { get; set; }

    }
    public class Location
    {
        public required string name { get; set; }
        public required string url { get; set; }

    }
    public class Character
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string status { get; set; }
        public required string species { get; set; }
        public required string type { get; set; }
        public required string gender { get; set; }
        public required Origin origin { get; set; }
        public required Location location { get; set; }
        public required string image { get; set; }
        public required IList<string> episode { get; set; }
        public required string url { get; set; }
        public DateTime created { get; set; }

    }
}
