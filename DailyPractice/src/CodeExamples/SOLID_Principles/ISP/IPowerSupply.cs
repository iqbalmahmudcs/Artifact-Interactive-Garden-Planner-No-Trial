using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP
{
    public interface IPowerSupply
    {
        void On();
        void Off();
    }
}
