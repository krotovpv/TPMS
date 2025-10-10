using System;
using System.Collections.Generic;
using System.Linq;

namespace TPMS_WF2
{
    public class HistoryData
    {
        public DateTime DateTime { get; }
        public string Pressure { get; } = string.Empty;
        public string Temperature { get; } = string.Empty;
        public string Number { get; } = string.Empty;
        public short Code { get; } = 0;

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
