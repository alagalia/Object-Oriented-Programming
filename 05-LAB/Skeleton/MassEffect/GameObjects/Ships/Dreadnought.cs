using System;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Dreadnought :Starship
    {
        public Dreadnought(string name, StarSystem location) 
            : base(name, 200, 300, 150, 700, location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            int damage = (this.Shields/2) + this.Damage;
            return new Laser(damage);
        }

        public override void RespondToAttack(IProjectile attack)
        {
            this.Shields += 50;
            base.RespondToAttack(attack);//преизползваме базовия клас
            this.Shields -= 50;
        }
    }
}
