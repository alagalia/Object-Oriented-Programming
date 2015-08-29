using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    public class Laser :Projectiles
    {
        public Laser(int damage)
            : base(damage)
        {
        }

        public override void Hit(IStarship ship)
        {
            ship.Shields -= this.Damage;
            if (this.Damage - ship.Shields > 0)
            {
                ship.Health -= this.Damage - ship.Shields;
            }
        }
    }
}