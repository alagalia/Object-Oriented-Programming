﻿using System;
using System.Linq;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Ships;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine) 
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string type = commandArgs[1];
            string shipName= commandArgs[2];
            string locationName = commandArgs[3];

            bool isStarShipAlreadyExis = this.GameEngine.Starships.Any(x => x.Name == shipName);
            if (isStarShipAlreadyExis)
            {
                throw new ArgumentException(Messages.DuplicateShipName);
            }

            var location = this.GameEngine.Galaxy.GetStarSystemByName(locationName);

            StarshipType shipType = (StarshipType)Enum.Parse(typeof(StarshipType),type);

            var ship=GameEngine.ShipFactory.CreateShip(shipType, shipName, location);
            this.GameEngine.Starships.Add(ship);

            for (int i = 4; i < commandArgs.Length; i++)
            {
                var enhancementName = (EnhancementType) Enum.Parse(typeof (EnhancementType), commandArgs[i]);
                var enhancement = this.GameEngine.EnhancementFactory.Create(enhancementName);
                ship.AddEnhancement(enhancement);
            }

            Console.WriteLine(Messages.CreatedShip, shipType,ship.Name);

        }
    }
}
