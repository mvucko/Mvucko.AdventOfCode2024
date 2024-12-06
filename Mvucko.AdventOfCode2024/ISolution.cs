using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvucko.AdventOfCode2024
{
    internal interface ISolution
    {
        public int TaskNumber { get; }
        public void Solve();
    }
}
