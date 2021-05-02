using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class coldblood
    {
        private string _pufferfish;
        private string _shark;
        private string _trout;
        private string _salmon;

        public string Salmon { get => _salmon; set => _salmon = value; }
        public string Trout { get => _trout; set => _trout = value; }
        public string Shark { get => _shark; set => _shark = value; }
        public string Pufferfish { get => _pufferfish; set => _pufferfish = value; }
    }
}
