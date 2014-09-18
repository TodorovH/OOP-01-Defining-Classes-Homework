using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02LaptopShop
{
    public class Battery
    {
        private string type;
        private float life;

        public Battery (string type = null)
        {
            this.Type = type;
        }

        public Battery(string type, float life) : this(type)
        {
            this.Life = life;
        }

        public string Type 
        {
            get 
            { 
                return this.type;
            }
            set 
            {
                if ((value != null) && (value.Length < 1))
                {
                    throw new ArgumentNullException("Invalid argument");
                }
                this.type = value;
            } 
        }

        public float Life 
        {
            get 
            { 
                return this.life; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours can't be negative");
                }
                this.life = value;
            }
        }

        public override string ToString()
        {
            string batteryStr = null;
            if (this.Type != null)
            {
                batteryStr += "battery: " + this.Type + "\n";
            }
            if (this.Life > 0)
            {
                batteryStr += "battery life: " + this.Life + " hours\n";
            }
            return batteryStr.ToString();
        }
    }
}
