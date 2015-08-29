using System.Collections.Generic;

namespace EnvironmentSystem.Models.Objects
{
    public class Snowflake : MovingObject
    {
        protected const char SnowflakeCharImage = '*';

        public Snowflake(int x, int y, int width, int height, Point direction)
            : base(x, y, width, height, direction)
        {
            this.ImageProfile = this.GenerateImageProfile();
        }

        protected virtual char[,] GenerateImageProfile()
        {
            return new char[,] {{SnowflakeCharImage}};
        }

        public override void RespondToCollision(CollisionInfo collisionInfo) // ако снежинката удари земята да изчезва
        {
            var hitObject = collisionInfo.HitObject;
            if (hitObject is Ground || hitObject is Snow)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
            //ако снежинката удари земята да се превърне в точка
        {
            var produceObject = new List<EnvironmentObject>();
            if (!this.Exists)
            {
                produceObject.Add(new Snow(
                    this.Bounds.TopLeft.X, this.Bounds.TopLeft.Y-1));
            }
            return produceObject;
        }
    }
}
