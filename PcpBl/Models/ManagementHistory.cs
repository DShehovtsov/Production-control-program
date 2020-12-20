using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcpBl.Models
{
    public class ManagementHistory
    {
        public int ManagementHistoryId { get; set; }

        public DateTime Date { get; set; }

        public string HistoryEvent { get; set; }

        public string PsEvent { get; set; }
    }
}
