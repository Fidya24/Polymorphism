using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Epson
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public void Print()
        {
            Console.WriteLine("Epson printer is printing. . . . ");
        }
    }
}