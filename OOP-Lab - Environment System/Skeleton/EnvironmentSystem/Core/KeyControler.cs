using System;
using EnvironmentSystem.Interfaces;

namespace EnvironmentSystem.Core
{
   public class KeyControler :IController
    {
       public event EventHandler Pause;

      
       public void ProcessInput()
       {
           if (Console.KeyAvailable)
           {
               var keyPress = Console.ReadKey();
               if (keyPress.Key==ConsoleKey.Spacebar)
               {
                   if (this.Pause!=null)
                   {
                       this.Pause(this, new EventArgs());
                   }
               }
           }
       }
    }
}
