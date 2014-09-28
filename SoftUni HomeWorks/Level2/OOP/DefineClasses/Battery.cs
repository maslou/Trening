using System;
using System.Reflection;
using System.Text;

namespace DefineClasses
{
    class Battery
    {
        private string name;
        private decimal batteryLive;

        public Battery(string name, decimal battLive)
        {
            this.battery = name;
            this.Live = battLive;
        }
        public Battery() : this(null, 0) { }

        public string battery
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public decimal Live
        {
            get
            {
                return this.batteryLive;
            }
            set
            {
                this.batteryLive = value;
            }
        }

        public override string ToString()
        {
            StringBuilder batStr = new StringBuilder();

            PropertyInfo[] props = this.GetType().GetProperties();

            foreach (PropertyInfo prop in props)
            {
                if (prop.GetValue(this, null) != null)
                {
                    batStr.AppendLine(prop.Name.ToString() + ": " + prop.GetValue(this, null));

                }
            }

            return batStr.ToString();
        }
    }
}
