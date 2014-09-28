using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClasses
{
    class Computer
    {
        private const string currency=" BGN";

        private string name;
        private List<Component> componets = new List<Component>();
        private decimal price;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.AddComponent(components);
        }

        public Computer(string name, Component component)
        {
            this.Name = name;
            this.AddComponent(component);
        }

        public Computer(string name)
        {
            this.Name = name;
            this.componets.Clear();
        }


        public string Name 
        { 
           get
            {
                return this.name;
            }
           set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public List<Component> Components
        {
            get
            {
                return this.componets;
            }
            set
            {
                this.componets.Clear();
                this.AddComponent(value);
            }
        }
        public decimal Price 
        { 
           get
            {
                return this.price;
            }
        }

        public void AddComponent(Component newComponent)
        {
            if (newComponent == null)
            {
                throw new ArgumentNullException("null element cannot be added");
            }

            this.componets.Add(newComponent);
            this.SetPrice();
        }
        public void AddComponent(List<Component> newComponents)
        {
            foreach (Component component in newComponents)
            {
                this.AddComponent(component);
            }
        }
        public override string ToString()
        {
            StringBuilder compStr = new StringBuilder();

            compStr.AppendLine("Computer Name: " + this.Name);

            foreach (Component currComp in this.Components)
            {
                compStr.AppendLine(currComp.ToString());
            }

            compStr.AppendLine("Price: " + this.Price + currency);

            return compStr.ToString();
        }

        private void SetPrice()
        {
            decimal currPrice = 0m;
            foreach (Component itemComponent in this.componets)
            {
                currPrice = currPrice + itemComponent.Price;
            }
            this.price = currPrice;
        }
    }
}
