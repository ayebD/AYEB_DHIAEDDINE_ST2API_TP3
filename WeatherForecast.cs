using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeahterAPI_TP
{
    class WeatherForecast
    {
        public class temp
        {
            public double day { get; set; }
        }

        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class daily
        {
            public long dt { get; set; }
            public temp temp { get; set; }
            public List<weather> weather { get; set; }

        }

        public class ForecastInfo
        {
            public List<daily> daily { get; set; }
        }
    }
}
