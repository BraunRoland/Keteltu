using System;
using System.Collections.Generic;
using System.Text;

namespace Keteltu
{
    internal interface IDrivable
    {
        public void Drive(int km);
        public int GetWheelsCount();
    }
}
