using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Locations;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public abstract class Starship:IStarship
    {
        protected Starship(string name, int health, int shields, int damage, double fuel, StarSystem location)
        {
            this.Name = name;
            this.Health = health;
            this.Shields = shields;
            this.Damage = damage;
            this.Fuel = fuel;
            this.Location = location;
        }
       

        public string Name { get; set; }

        public int Health { get; set; }

        public int Shields { get; set; }

        public int Damage { get; set; }

        public double Fuel { get; set; }

        public StarSystem Location { get; set; }


        public abstract IProjectile ProduceAttack();

        public virtual void RespondToAttack(IProjectile attack)
        {
             attack.Hit(this);               
        }

        //създаваме PRIAVTE лист, за да можем да добавяме елементи, т.като към IEnumarable не можем. След което го подаваме към публичният IEnumarable. Така отвън не мога да достъпват
        private readonly IList<Enhancement> enhancements=new List<Enhancement>();

        public IEnumerable<Enhancement> Enhancements
        {
            get { return this.enhancements; }
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            if (enhancement==null)
            {
                throw new ArgumentNullException("Enhancement cannot be null");
            }
            this.enhancements.Add(enhancement);
            this.ApplyEnhancementEffects(enhancement);
        }

        private void ApplyEnhancementEffects(Enhancement enhancement)
        {
            this.Damage += enhancement.DamageBonus;
            this.Fuel += enhancement.FuelBonus;
            this.Shields += enhancement.ShieldBonus;

        }

        public override string ToString() // презаписваме метода и избираме имената от enhancement с LINQ, ако не е празен списъкът
        {
            StringBuilder output =new StringBuilder();
             string line1 = string.Format("--{0} - {1}",this.Name,this.GetType().Name);
             output.AppendLine(line1);
            if (this.Health<=0)
            {
                output.Append("(Destroyed)");
            }
            else
            {
                output.AppendLine(string.Format("-Location: {0}", this.Location.Name));
                output.AppendLine(string.Format("-Health: {0}", this.Health));
                output.AppendLine(string.Format("-Shields: {0}", this.Shields));
                output.AppendLine(string.Format("-Damage: {0}", this.Damage));
                output.AppendLine(string.Format("-Fuel: {0:F1}", this.Fuel));

                //string enhancement = "N/A";
                //if (this.enhancements!=null)
                //{
                //    enhancement = string.Join(", ", this.enhancements.Select(e => e.Name));
                //}
                string enhancementString = enhancements.Any()? string.Join(
                    ", ", this.enhancements.Select(e => e.Name)): "N/A";

                output.Append("-Enhancements: "+ enhancementString);

            }
            return output.ToString();
        }
    }
}
