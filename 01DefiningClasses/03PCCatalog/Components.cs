using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03PCCatalog
{
    class Components
    {
        private string name;
        private decimal price;
        public string Details { get; set; }

        public Components(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name of component cannot be empty or null");
                }
                this.name = value;
            }
        }
        public decimal Price 
        {
            get { return this.price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("The price of component cannot take negative value");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            string componentToPrint = this.Name + " " + this.Price + " " + this.Details;
            return componentToPrint;
        }
    }
}
