using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace BinaryPuzzle.Model
{
    public class Timer
    {
        public DispatcherTimer Dt { get; set; }

        public int Increment { get; set; }
    }
}
