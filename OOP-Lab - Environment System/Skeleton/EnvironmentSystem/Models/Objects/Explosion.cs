using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    class Explosion :Tail
    {
        public Explosion(int x, int y, int lifeTime = 2) 
            : base(x, y, lifeTime)
        {
        }
    }
}
