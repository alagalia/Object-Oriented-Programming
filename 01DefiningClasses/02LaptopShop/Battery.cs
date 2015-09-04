using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02LaptopShop
{
    class Battery
    {
        private string modelBattery;
        private int cells;
        private int powerBattery;

        public Battery(string modelBattery, int cells, int powerBattery)
        {
            this.ModelBattery = modelBattery;
            this.Cells = cells;
            this.PowerBattery = powerBattery;
            
        }

        public string ModelBattery
        {
            get { return this.modelBattery; }
            set {
                value = value.Trim();
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("BatteryType type must not be empty!");
                }
                this.modelBattery = value;
            }
        }
        public int Cells 
        {
            get { return this.cells; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("BatteryCells must not be negative!");
                }
                this.cells = value;
            }
        }
        public int PowerBattery 
        {
            get { return this.powerBattery; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("BatteryPower must not be negative!");
                }
                this.powerBattery = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0},{1}-cells,{2} mAh",this.ModelBattery,this.Cells,this.powerBattery);
        }
    }
}
