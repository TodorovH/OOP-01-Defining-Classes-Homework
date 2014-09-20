using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03PCCatalog
{
    class Component
    {
        private string name;
        private decimal price;
        private string details;

        public Component (string name, decimal price, string details) 
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public Component (string name, decimal price) :this(name, price, null) { }

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
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.price = value;
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
                if ((value != null) && (value.Length < 1))
                {
                    throw new ArgumentException("Invalid argument");
                }
                this.details = value;
            }
        }

        public override string ToString()
        {
            string componentStr = null;
            componentStr += "Name: " + this.Name;
            if (this.details != null)
            {
                componentStr += ", details: " + this.Details;
            }
            componentStr += ", price: " + this.Price + " BGN";
            return componentStr.ToString();
        }
    }
}
