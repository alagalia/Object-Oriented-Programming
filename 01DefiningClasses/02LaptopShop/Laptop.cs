using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LaptopShop
{
    class Laptop
    {
        //fields
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string card;
        private string hdd;
        private string screen;
        private Battery battery;
        private double batteryLife;
        private decimal price;

        //constructor 1
        public Laptop(string model, decimal price)
            : this(null, null, 0, null, 0)
        {
            this.Model = model;
            this.Price = price;
        }

        //constructor 2
        public Laptop(string model, string processor, int ram, string hdd, decimal price)
        {
            this.Model = model;
            this.Processor = processor;
            this.RAM = ram;
            this.HDD = hdd;
            this.Price = price;
        }

        //Constructor all info + battery info
        public Laptop(string model, string manufacturer, string processor, int ram, string card, string hdd, string screen, Battery battery, double batteryLife, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.Card = card;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
            this.Price = price;
        }

        //property
        public string Model 
        { 
            get {return this.model;}
            set {
                value = value.Trim();
                if (value=="")
                {
                    throw new ArgumentException("Model cannot take empty string as value");
                }
                this.model = value; 
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set {
                value = value.Trim();
                if (value == "")
                {
                    throw new ArgumentException("Manufavturer cannot take empty string as value");
                }
                this.manufacturer = value; 
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set {
                value = value.Trim();
                if (value == "")
                {
                    throw new ArgumentException("Field Processor cannot take empty string as value");
                } 
                this.processor = value;
            }
        }
        public int RAM
        {
            get { return this.ram; }
            set {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Field RAM cannot take negativ numeric data as value");
                } this.ram = value;
            }
        }
        public string Card
        {
            get { return this.card; }
            set {
                value = value.Trim();
                if (value == "")
                {
                    throw new ArgumentException("Field Graphic gard cannot take empty string as value");
                }
                this.card = value;
            }
        }
        public string HDD
        {
            get { return this.hdd; }
            set {
                value = value.Trim();
                if (value == "")
                {
                    throw new ArgumentException("Field HDD cannot take empty string as value");
                } 
                this.hdd = value;
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set {
                value = value.Trim();
                if (value == "")
                {
                    throw new ArgumentException("Field Screen cannot take empty string as value");
                } 
                this.screen = value;
            }
        }
        public Battery Battery
        {
            get {  return this.battery; }
            set { this.battery = value; }
        }
        public double BatteryLife
        {
            get { return this.batteryLife; }
            set { 
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Field Battery Life cannot take negativ numeric data as value");
                }
                this.batteryLife = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set { 
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Field Price cannot take negativ numeric data as value");
                } this.price = value;
            }
        }



        public override string ToString()
        {
            return string.Format("Model: {0}\nManufacturer: {1}\nProcessor: {2}\nRAM: {3} GB \nCard:{4} \nHDD: {5} \nScreen: {6} \nBattery: {7} \nBatteryLife: {8} hours \nPrice: {9} lv", this.Model, this.Manufacturer, this.Processor, this.RAM, this.Card, this.HDD, this.Screen, this.Battery, this.BatteryLife, this.Price);

            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine(string.Format("Laptop: {0}", this.Manufacturer ?? "[no info]"));
            //sb.AppendLine(string.Format("Model: {0}", this.Model ?? "[no info]"));
            //sb.AppendLine(string.Format("Processor: {0}", this.Processor ?? "[no info]"));
            //sb.AppendLine(string.Format("Ram: {0} GB", this.RAM.ToString() ?? "[no info]"));
            //sb.AppendLine(string.Format("Graphics: {0}", this.Card ?? "[no info]"));
            //sb.AppendLine(string.Format("HDD: {0}", this.HDD ?? "[no info]"));
            //sb.AppendLine(string.Format("Screen: {0}", this.Screen ?? "[no info]"));
            //sb.AppendLine(string.Format("Battery: {0}", this.Battery));
            //sb.AppendLine(string.Format("Price: {0:F2} lv.", this.Price.ToString() ?? "[no info]"));
            //return sb.ToString();

        }
    }
}
