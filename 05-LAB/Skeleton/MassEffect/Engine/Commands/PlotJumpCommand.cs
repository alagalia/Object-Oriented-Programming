using System;
using System.Linq;
using MassEffect.GameObjects;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class PlotJumpCommand : Command
    {
        public PlotJumpCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            string destinationName = commandArgs[2];

            IStarship ship = GetStarShipByName(shipName);
            this.ValidateShipExistance(ship);
            var previousLocation = ship.Location;
            var destination = GameEngine.Galaxy.GetStarSystemByName(destinationName);


            if (ship.Location.Name==destinationName)
            {
                Console.WriteLine(string.Format(Messages.ShipAlreadyInStarSystem,destinationName));
            }

            this.GameEngine.Galaxy.TravelTo(ship,destination);

            Console.WriteLine(Messages.ShipTraveled,ship.Name,previousLocation.Name,destination.Name);
        }
    }
}
