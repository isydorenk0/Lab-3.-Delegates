using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class FiltersFlds
    {
        public FiltersFlds(string number, DateTime mindate, DateTime maxdate, string filtermsg, string filterlgc)
        {
            selectedNumber = number;
            minDate = mindate;
            maxDate = maxdate;
            filterMsg = filtermsg;
            filterLgc = filterlgc;
        }
        public string selectedNumber { get; set; }
        public DateTime minDate { get; set; }
        public DateTime maxDate { get; set; }
        public string filterMsg { get; set; }
        public string filterLgc { get; set; }
    }
}
