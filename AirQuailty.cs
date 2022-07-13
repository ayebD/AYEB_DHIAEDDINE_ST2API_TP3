using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeahterAPI_TP
{
    class AirQuailty
    {   
        public class main
        {
            public double aqi { get; set; }
        }

        public class components
        {
            public double co { get; set; }
        }
        public class list
        {
            public main aqi { get; set; }
            public components co { get; set; }
        }

        public class AirQualityInfo
        {
            public List<list> list { get; set; }
        }
    }
}
