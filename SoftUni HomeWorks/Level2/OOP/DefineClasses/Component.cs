using System;


namespace DefineClasses
{
    class Component
    {
        private const string currency = " BGN";

        private string name;
        private string details;
        private decimal price;

        public Component(string name, decimal price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public Component(string name, decimal price) : this(name, price, null)
        {
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
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public string Details 
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The prace must be greater than 0");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return (this.Name + ": " + this.price.ToString() + currency);
        }
    }
}
