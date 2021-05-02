using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Fish
    {
        private coldblood _coldblood;
        private Warmblood _warmblood;

        internal coldblood Coldblood { get => _coldblood; set => _coldblood = value; }
        internal Warmblood Warmblood { get => _warmblood; set => _warmblood = value; }
    }
}
