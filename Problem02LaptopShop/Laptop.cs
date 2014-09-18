using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02LaptopShop
{
    class Laptop
    {
        private string model;
        private string manifacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop (string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop (string model, decimal price, string manifacturer = null, string processor = null,
            string ram = null, string graphicsCard = null, string hdd = null, string screen = null,
            Battery battery = null) :this (model, price)
        {
            this.Manifacturer = manifacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
        }

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

        public string Manifacturer 
        { 
            get
            {
                return this.manifacturer;
            }
            set
            {
                if ((value != null) && (value.Length < 1))
                {
                    throw new ArgumentException("Invalid argument");
                }
                this.manifacturer = value;
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
                if ((value != null) && (value.Length < 1))
                {
                    throw new ArgumentException("Invalid argument");
                }
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
                if ((value != null) && (value.Length < 1))
                {
                    throw new ArgumentException("Invalid argument");
                }
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
                if ((value != null) && (value.Length < 1))
                {
                    throw new ArgumentException("Invalid argument");
                }
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
                if ((value != null) && (value.Length < 1))
                {
                    throw new ArgumentException("Invalid argument");
                }
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
                if ((value != null) && (value.Length < 1))
                {
                    throw new ArgumentException("Invalid argument");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; } 
        }

        public override string ToString()
        {
            string result = null;
            result += "model: " + this.Model + "\n";
            if (this.Manifacturer != null)
            {
                result += "manifacturer: " + this.Manifacturer + "\n";
            }
            if (this.Processor != null)
            {
                result += "processor: " + this.Processor + "\n";
            }
            if (this.Ram != null)
            {
                result += "RAM: " + this.Ram + "\n";
            }
            if (this.GraphicsCard != null)
            {
                result += "graphics card: " + this.GraphicsCard + "\n";
            }
            if (this.Hdd != null)
            {
                result += "HDD: " + this.Hdd + "\n";
            }
            if (this.Screen != null)
            {
                result += "screen: " + this.Screen + "\n";
            }
            if (this.Battery != null)
            {
                result += this.Battery.ToString();
            }
            result += "price: " + this.Price + " lv\n";
            return result.ToString();
        }
    }
}
