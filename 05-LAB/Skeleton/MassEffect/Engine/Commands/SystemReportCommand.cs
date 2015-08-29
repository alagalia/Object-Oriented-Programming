using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.Interfaces;

namespace MassEffect.Engine.Commands
{
    public class SystemReportCommand :Command
    {
         public SystemReportCommand(IGameEngine gameEngine)
                : base(gameEngine)
            {

            }

            public override void Execute(string[] commandArgs)
            {
                string starSystemName = commandArgs[1];
               
               
                var starShipsFromThisSystem = GameEngine.Starships
                    .Where(s => s.Location.Name == starSystemName); //списък на корабите от системата starSystemName

                //избираме тези кораби, които са оцелели
                var intactShips = starShipsFromThisSystem
                    .Where(s => s.Health > 0)//избираме тези, които са оцелели
                    .OrderByDescending(s => s.Health)//подреждаме по Health
                    .ThenByDescending(s => s.Shields);//подреждаме по Shields

                StringBuilder output = new StringBuilder();
                output.AppendLine("Intact ships:");
                output.AppendLine(intactShips.Any() ? string.Join("\n", intactShips) : "N/A");

                //избираме тези кораби, които са разрушени
                var destoyedShip = starShipsFromThisSystem
                    .Where(s => s.Health <= 0)
                    .OrderBy(s => s.Name);


                output.AppendLine("Destroyed ships:");
                if (destoyedShip.Any())
                {
                    string intactShipsString = string.Join("\n", destoyedShip);
                    output.Append(intactShipsString);
                }
                else
                {
                    output.Append("N/A");
                }
                Console.WriteLine(output.ToString());
            }
    }
}
