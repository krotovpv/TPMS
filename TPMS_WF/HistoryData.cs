using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMS_WF
{
    public class HistoryData
    {
        public DateTime DateTime { get; }
        public string Pressure { get; }
        public string Temperature { get; }
        public ETypeTire TypeTire { get; }

        private static readonly List<HistoryData> History = new List<HistoryData>();

        public HistoryData(string pressure, string temperature, ETypeTire typeTire)
        {
            DateTime = DateTime.Now;
            Pressure = pressure;
            Temperature = temperature;
            TypeTire = typeTire;
            History.Add(this);
        }

        public static HistoryData[] GetHistory(ETypeTire typeTire)
        {
            return History.Where(x => x.TypeTire == typeTire).ToArray();
        }
    }
}
