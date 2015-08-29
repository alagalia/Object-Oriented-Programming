using System;
using System.Collections.Generic;
using EnvironmentSystem.Models.Data.Structures;

namespace EnvironmentSystem.Models.Objects
{
    class Stars:EnvironmentObject
    {
        
        private static char DefaultStarImageCharacter = 'O';
        private const int StarImageUpdateFrequence = 10;
        private int updateCount = 0;
        private static readonly Random randomize = new Random();
        private static char[] starImageProgiles = new char[] {'#', '@', 'O'};

        public Stars(int x, int y) : base(x, y, 1, 1)
        {
            this.ImageProfile = new char[,] { { DefaultStarImageCharacter } };
        }

        public Stars(Rectangle bounds) : base(bounds)
        {
        }

        public override void Update()
        {
            if (updateCount == StarImageUpdateFrequence)
            {
                int index = randomize.Next(0, starImageProgiles.Length);
                this.ImageProfile=new char[,]{{starImageProgiles[index]}};
                this.updateCount = 0;
            }
            updateCount++;

        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            if ( collisionInfo.HitObject is Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return  new List<EnvironmentObject>();
        }
    }
}
