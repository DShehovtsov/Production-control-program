using PcpBl;
using PcpBl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcpUI
{
    public class InitializeBd
    {
        public Bird[] Get(string Bird)
        {
            using (PcpContext entities = new PcpContext())
            {
                return entities.Birds.Where(e => e.Name == Bird).ToArray();
            }
        }

    }
}
