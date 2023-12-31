﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCM
{
    internal class WeatherInfo
    {
        public class coord
        {

            public double lon { get; set; }
            public double lat { get; set; }
        }
        public class weather
        {
            public double id { get; set; }
            public string main { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double humidity { get; set; }
        }
        public class clouds 
        {
            public double all { get; set; }
        }
        public class wind
        {
            public double speed { get; set; }
        }


        public class root
        {
            public string name { get; set; }
            public double dt { get; set; }
            public wind wind { get; set; }
            public main main { get; set; }
            public List<weather> weatherList { get; set; }
            public coord coordinate { get; set; }
            public clouds clouds { get; set; }

        }
    }
}

