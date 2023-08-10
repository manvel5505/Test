using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp239.model
{
    internal class Shapes
    {
        public string Shape { get; set; }
        public string Color1 { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
    public enum Color
    {
        red,
        green,
        blue,
        yellow,
        magenta,
        white
    }
}
