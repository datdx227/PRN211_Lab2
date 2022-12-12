using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SercurityPanel
{
    public class Security
    {
        public string Date { get; set; }
        public string Status { get; set; }

        public Security()
        {
        }

        public Security(string date, string status)
        {
            Date = date;
            Status = status;
        }

        public override string? ToString()
        {
            return Date + "\t" + Status;
        }
    }
}
