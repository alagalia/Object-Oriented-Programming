namespace EnvironmentSystem.Core.Generator
{
    using System;
    using System.Collections.Generic;

    using EnvironmentSystem.Models;
    using EnvironmentSystem.Models.Objects;

    public class ObjectGenerator
    {
        private const int SnowflakeCount = 10;
        private readonly int WorldWidth;
        private readonly int WorldHeight;

        public ObjectGenerator(int worldWidth, int worldHeight)
        {
            this.WorldWidth = worldWidth;
            this.WorldHeight = worldHeight;
        }

        /// <summary>
        /// Adds objects only once to the passed collection.
        /// </summary>
        /// <param name="objects"></param>
        public void Initiliaze(List<EnvironmentObject> objects)
        {
            objects.Add(new Ground(0, 25, 50, 2));

            Random rnd = new Random();
            for (int i = 0; i < 40; i++)
            {
                int x = rnd.Next(0, WorldWidth);
                int y = rnd.Next(0, 25);
                objects.Add(new Stars(x, y));
            }

            objects.Add(new UnstableStar(20, 5, new Point(-1, 1)));

        }

        /// <summary>
        /// Dynamically adds objects to the passed collection.
        /// </summary>
        /// <param name="objects"></param>
        public void DynamicallyAdd(List<EnvironmentObject> objects)
        {
            Random rnd = new Random();
            for (int i = 0; i < SnowflakeCount; i++)
            {
                int generateFlag = rnd.Next(0, 5);

                if (generateFlag == 1)
                {
                    int x = rnd.Next(0, WorldWidth);
                    //var envObject = new Snowflake(x, 1, 1, 1, new Point(0, 1));

                    //objects.Add(envObject);
                }
            }
        }

        
    }
}
