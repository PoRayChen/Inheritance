using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Fly
    {
        private string _swallow;
        private string _robin;

        public string Robin { get => _robin; set => _robin = value; }
        public string Swallow { get => _swallow; set => _swallow = value; }
    }
}
