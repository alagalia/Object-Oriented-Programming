using System.Collections.Generic;

namespace EnvironmentSystem.Models.Objects
{
    class UnstableStar:FallingStar
    {
        private int lifeTime;
        public UnstableStar(int x, int y, Point direction, int lifeTime=8) : base(x, y, direction)
        {
            this.lifeTime = lifeTime;
        }

        public override void Update()
        {
            this.lifeTime--;
            if (this.lifeTime <= 0)
            {
                this.Exists = false;
            }
            base.Update();
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            if (this.Exists)
            {
                return base.ProduceObjects();
            }
            else
            {
                List< EnvironmentObject> explosion = new List<EnvironmentObject>();

                for (int y = this.Bounds.TopLeft.Y - 2; y <= this.Bounds.TopLeft.Y + 2; y++)
                {
                    for (int x = this.Bounds.TopLeft.X - 2; x <= this.Bounds.TopLeft.X + 2; x++)
                    {

                        if (!(x==this.Bounds.TopLeft.X & this.Bounds.TopLeft.Y==y))
                        {
                            explosion.Add(new Explosion(x, y));
                        }
                        
                        
                    }
                }
                return explosion;
            }
        }

        
    }
}
