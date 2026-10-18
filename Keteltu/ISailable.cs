using System;
using System.Collections.Generic;
using System.Text;

namespace Keteltu
{
    internal interface ISailable
    {
        public void Sail(int knots);
        public string GetAnchorStatus();
    }
}
