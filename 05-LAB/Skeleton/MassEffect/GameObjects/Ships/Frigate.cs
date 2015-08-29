using System;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Frigate :Starship
    {
        private int ProjectilesFired { get; set; }
        public Frigate(string name, StarSystem location) : base(name, 60, 50, 30, 220, location)
        {
            this.ProjectilesFired = 0;//in addition 
        }

        public override IProjectile ProduceAttack()
        {
            this.ProjectilesFired++; //увеличаваме го, защото по-долу има обратна връзка колко са изстреляни
            return new ShieldReaver(this.Damage);
        }

        public override string ToString()
        {
            string output = base.ToString();
            if (this.Health>0)
            {
                output += string.Format("\n-Projectiles fired: {0}", this.ProjectilesFired);
            }
            return output;
        }
    }
}
