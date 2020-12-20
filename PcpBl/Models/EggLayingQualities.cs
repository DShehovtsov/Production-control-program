using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcpBl.Models
{
    public class EggLayingQualities
    {
        public int EggLayingQualitiesId { get; set; }
        public int BirdId { get; set; }
        public virtual Bird Bird { get; set; }
        public DateTime DateEgg { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Bird> Birds { get; set; }
        public EggLayingQualities()
        {
            Birds = new List<Bird>();
        }
    }
}
