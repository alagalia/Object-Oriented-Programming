﻿using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    class PenetrationShell :Projectiles
    {
        public PenetrationShell(int damage)
            : base(damage)
        {
        }

        public override void Hit(IStarship ship)
        {
            ship.Health -= this.Damage;
        }
    }
}
