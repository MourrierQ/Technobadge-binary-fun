using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPuzzle.Model
{
    public class Cell
    {
        public string Bit { get; set; }

        public double  HorizontalValue { get; set; }

        public double  VerticalValue { get; set; }

        public ResultBox VerticalTarget { get; set; }

        public ResultBox HorizontalTarget { get; set; }

        public int Size { get; set; }
        public int FontSize { get; set; }
    }
}
