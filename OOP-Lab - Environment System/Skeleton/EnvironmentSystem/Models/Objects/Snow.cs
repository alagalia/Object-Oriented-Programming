using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvironmentSystem.Models.Data.Structures;

namespace EnvironmentSystem.Models.Objects
{
   public class Snow :EnvironmentObject
    {
       const char  snowProfile = '.';
       public Snow(int x, int y) : base(x, y, 1, 1)
       {
           this.ImageProfile = new char[,] { { snowProfile } };

       }

       public override void Update()
       {
           
       }

       public override void RespondToCollision(CollisionInfo collisionInfo)
       {
       }

       public override IEnumerable<EnvironmentObject> ProduceObjects()
       {
           return new List<EnvironmentObject>();
       }
    }
}
