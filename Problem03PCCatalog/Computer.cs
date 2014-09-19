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
        private Component processor;
        private Component motherboard;
        private Component graphicsCard;
        private Component ram;
        private Component hdd;
        private Component powerSupply;
        private Component box;
        private decimal totalPrice;

        public Computer (
            string name,
            Component processor = null, 
            Component motherboard = null, 
            Component graphicsCard = null,
            Component ram = null, 
            Component hdd = null, 
            Component powerSupply = null, 
            Component box = null)
        {
            this.Name = name;
            this.TotalPrice = totalPrice;
            this.Processor = processor;
            this.Motherboard = motherboard;
            this.GraphicsCard = graphicsCard;
            this.Ram = ram;
            this.Hdd = hdd;
            this.PowerSupply = powerSupply;
            this.Box = box;
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

        public Component Processor 
        { 
            get { return this.processor; }
            set { this.processor = value; }
        }

        public Component Motherboard 
        {
            get { return this.motherboard; }
            set { this.motherboard = value; }
        }

        public Component GraphicsCard 
        {
            get { return this.graphicsCard; }
            set { this.graphicsCard = value; }
        }

        public Component Ram 
        {
            get { return this.ram; }
            set { this.ram = value; }
        }

        public Component Hdd 
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }

        public Component PowerSupply
        {
            get { return this.powerSupply; }
            set { this.powerSupply = value; }
        }

        public Component Box
        {
            get { return this.box; }
            set { this.box = value; }
        }

        public void GetTotalPrice()
        {
            if (this.Processor != null)
            {
                this.totalPrice += Processor.Price;
            }
            if (this.Motherboard != null)
            {
                this.totalPrice += Motherboard.Price;
            }
            if (this.GraphicsCard != null)
            {
                this.totalPrice += GraphicsCard.Price;
            }
            if (this.Ram != null)
            {
                this.totalPrice += Ram.Price;
            }
            if (this.Hdd != null)
            {
                this.totalPrice += Hdd.Price;
            }
            if (this.PowerSupply != null)
            {
                this.totalPrice += PowerSupply.Price;
            }
            if (this.Box != null)
            {
                this.totalPrice += Box.Price;
            }
        }

        public override string ToString()
        {
            string computerStr = null;
            computerStr += "Name: " + this.Name + "\n";
            if (this.Processor != null)
            {
                computerStr += "Processor: " + this.Processor + "\n";
            }
            if (this.Motherboard != null)
            {
                computerStr += "Motherboard: " + this.Motherboard + "\n";
            }
            if (this.GraphicsCard != null)
            {
                computerStr += "Graphics Card: " + this.GraphicsCard + "\n";
            }
            if (this.Ram != null)
            {
                computerStr += "RAM: " + this.Ram + "\n";
            }
            if (this.Hdd != null)
            {
                computerStr += "HDD: " + this.Hdd + "\n";
            }
            if (this.PowerSupply != null)
            {
                computerStr += "Power Supply: " + this.PowerSupply + "\n";
            }
            if (this.Box != null)
            {
                computerStr += "Box: " + this.Box + "\n";
            }
            GetTotalPrice();
            computerStr += "Total Price: " + this.totalPrice + " BGN\n";

            return computerStr.ToString();
        }
    }
}
