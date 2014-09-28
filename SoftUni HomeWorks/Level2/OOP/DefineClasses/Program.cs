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

            Component dellComplateConfif = new Component("Dell Complate Configuration 1", 1050m);
            Component mouseDell1 = new Component("mouse dell basic", 4m);
            Component kayBoardDell1 = new Component("KayBoard dell basic", 5.5m);
            Component displayDell1 = new Component("Display Dell Basic", 145.80m);

            List<Component> dellNoDispay= new List<Component>();
            dellNoDispay.Add(dellComplateConfif);
            dellNoDispay.Add(mouseDell1);
            dellNoDispay.Add(kayBoardDell1);

            Computer dellNoDisplay = new Computer("Dell Basic No Display", dellNoDispay);

            Computer dellWithDisplay = new Computer("Dell Basic and Display", dellNoDispay);
            dellWithDisplay.AddComponent(displayDell1);

            List<Computer> computers = new List<Computer>();
            computers.Add(dellWithDisplay);
            computers.Add(dellNoDisplay);
            

            List<Computer> orderedComuters = computers.OrderBy(o=>o.Price).ToList();

            foreach (Computer comp in orderedComuters)
            {
                Console.WriteLine(comp.ToString());
            }
 
        }
    }
}
