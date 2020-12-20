using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcpBl.Models
{
    public class WorkShop
    {
        public int WorkShopId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Bird> Birds { get; set; }
        public WorkShop()
        {
            Birds = new List<Bird>();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
