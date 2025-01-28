using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP
{
    public class Laptop
    {
        public bool isMonitorOn;
        public bool isCpuOn;


        public void TurnOnLaptop()
        {
            TurnOnMonitor();
            TurnOnCPU();
        }

        private void TurnOnMonitor()
        {

        }

        private void TurnOnCPU()
        {

        }
    }
}
