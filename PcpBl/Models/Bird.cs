using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcpBl.Models
{
    public class Bird
    {
        public int BirdId { get; set; }
        public string Name { get; set; }
        public int WorkShopId { get; set; }
        public virtual WorkShop WorkShop { get; set; }
        public DateTime Age { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return Name;
        }


        


        
    }
}
