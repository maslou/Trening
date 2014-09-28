using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Battery lenovoStandartBattery = new Battery("Li-Ion, 4-cells, 2550 mAh", (decimal)4.5);

            Laptop lenovo1 = new Laptop("Lenovo ThinkPad430", (decimal)1030.5, lenovoStandartBattery);
            Console.WriteLine(lenovo1.ToString());
        }
    }
}
