using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird
    {
        private Fly _Fly;
        private Nonfly _Nonfly;

        internal Fly Fly { get => _Fly; set => _Fly = value; }
        internal Nonfly Nonfly { get => _Nonfly; set => _Nonfly = value; }
    }
}
