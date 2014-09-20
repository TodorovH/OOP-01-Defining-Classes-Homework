using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03PCCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components = new List<Component>();
        private decimal totalPrice;

        public Computer (string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
            this.TotalPrice = totalPrice;
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
            get { return components; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value cannot be empty");
                }
                this.components = value; 
            }
        }
    
        public decimal TotalPrice 
        {
            get
            {
                return this.totalPrice;
            }
            set
            {
                GetTotalPrice();
            }
        }

        public void GetTotalPrice()
        {
            totalPrice = 0;
            foreach (Component c in components)
            {
                this.totalPrice += c.Price;
            }
        }

        public override string ToString()
        {
            string computerStr = null;
            computerStr += "Name: " + this.Name + "\n";
            foreach (Component c in components)
            {
                computerStr += c.ToString() + "\n";
            }
            GetTotalPrice();
            computerStr += "Total Price: " + this.totalPrice + " BGN\n";
            return computerStr.ToString();
        }
    }
}
