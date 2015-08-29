using System.Collections.Generic;
using EnvironmentSystem.Models.Data.Structures;

namespace EnvironmentSystem.Models.Objects
{
    class Tail:EnvironmentObject
    {
        private int lifeTime;
        public Tail(int x, int y, int lifeTime=1) : base(x, y, 1, 1)
        {
            this.lifeTime = lifeTime;
            this.ImageProfile= new char[,]{{'*'}};
        }

        public override void Update()
        {
            this.lifeTime--;

            if (this.lifeTime<=0)
            {
                this.Exists = false;
            }
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return  new List<EnvironmentObject>();
        }
    }
}
