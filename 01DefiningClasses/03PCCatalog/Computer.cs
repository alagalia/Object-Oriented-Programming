using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PCCatalog
{
    class Computer
    {
        private string name;
        private List<Components> components;
        private decimal price;

        public Computer(string name, decimal price) :this(name, null, price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Computer(string name, List<Components> components, decimal price)
        {
            this.Name = name;
            this.Components = components;
            this.Price = price;
        }
        
        public string  Name
        { 
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Computer`s name cannot be empty or null");
                }
                this.name = value;
            }
        }

        public List<Components> Components
        {
            get { return this.components; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("No value");
                }
                this.components = value;
            }
        }
       
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Computer`s price cannot take negative value");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Name: {0}", this.Name));
            foreach (var component in components)
            {
                sb.AppendLine(string.Format("Component: {0}, price: {1} BGN", component.Name, component.Price));
            }
            sb.AppendLine(string.Format("Total computer prize: {0} BGN", this.Price));
            return sb.ToString();
        }
        
       

    }
}
