using System.Collections.Generic;
using EnvironmentSystem.Models.Objects;

namespace EnvironmentSystem.Models
{
    public class FallingStar: MovingObject
    {
        private const char FallingStarImageCharacter = 'O';
        public FallingStar(int x, int y, Point direction) : base(x, y, 1, 1, direction)
        {
            this.ImageProfile = new char[,] { { FallingStarImageCharacter } };
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            if (collisionInfo.HitObject is Ground || collisionInfo.HitObject is Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            List<EnvironmentObject> produceObjects = new List<EnvironmentObject>();

            int directionX = this.Direction.X;
            int directionY = this.Direction.Y;
            produceObjects.Add(new Tail(this.Bounds.TopLeft.X -this.Direction.X, this.Bounds.TopLeft.Y-this.Direction.Y));
            produceObjects.Add(new Tail(this.Bounds.TopLeft.X - 2 *this.Direction.X, this.Bounds.TopLeft.Y - 2 * this.Direction.Y));
            produceObjects.Add(new Tail(this.Bounds.TopLeft.X - 3 *this.Direction.X, this.Bounds.TopLeft.Y - 3*this.Direction.Y));
            return produceObjects;
            
        }
    }
}
