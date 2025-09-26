using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMS_WF2
{
    internal class HistoryData
    {
        public DateTime DateTime { get; }
        public string Pressure { get; }
        public string Temperature { get; }
        public string Number { get; }
        public short Code { get; }

        private static readonly List<HistoryData> History = new List<HistoryData>();

        public HistoryData(string pressure, string temperature, string number, short code)
        {
            DateTime = DateTime.Now;
            Pressure = pressure;
            Temperature = temperature;
            Number = number;
            Code = code;
            History.Add(this);
        }

        public static HistoryData[] GetHistory(string number)
        {
            return History.Where(x => x.Number == number).ToArray();
        }
    }
}
