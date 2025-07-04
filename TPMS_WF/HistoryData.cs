using System;
using System.Collections.Generic;

namespace TPMS_WF
{
    public class HistoryData
    {
        public DateTime DateTime { get; set; }
        public string Pressure { get; set; }
        public string Temperature { get; set; }
        public ETypeTire TypeTire { get; set; }

        public static readonly List<HistoryData> History = new List<HistoryData>();

        public HistoryData(string pressure, string temperature, ETypeTire typeTire)
        {
            DateTime = DateTime.Now;
            Pressure = pressure;
            Temperature = temperature;
            TypeTire = typeTire;
            History.Add(this);
        }
    }
}
