using System;
using System.Reflection;
using System.Text;

namespace DefineClasses
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(
            string model,
            decimal price,
            string manufacturer,
            string processor,
            string ram,
            string graphicsCard,
            string hdd,
            string screen,
            Battery batt)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = batt;
        }

        public Laptop(string model, decimal price) :
            this(model, price, null, null, null, null, null, null, null)
        { }

        public Laptop(string model, decimal price, Battery batt) :
            this(model, price, null, null, null, null, null, null, batt) { }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be empty");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                this.processor = value;
            }
        }

        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The price cannot be empty");
                }

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price canot be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder laptopStr = new StringBuilder();

            PropertyInfo[] props = this.GetType().GetProperties();

            foreach (PropertyInfo prop in props)
            {
                if (prop.GetValue(this, null) != null)
                {
                    if (prop.PropertyType.IsInstanceOfType(Battery))
                    {
                        string batInfo = prop.ToString();
                        laptopStr.AppendLine(this.Battery.ToString());
                    }
                    else
                    {
                        laptopStr.AppendLine(prop.Name.ToString() + ": " + prop.GetValue(this, null));
                    }
                }
            }

            return laptopStr.ToString();
        }

        //  PropertyInfo[] props=typeof(Laptop).GetProperties();
    }
}
