using System.Linq;
using MassEffect.Exceptions;

namespace MassEffect.Engine.Commands
{
    using System;

    using MassEffect.Interfaces;

    public abstract class Command
    {
        protected Command(IGameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        public IGameEngine GameEngine { get; set; }

        public IStarship GetStarShipByName(string name)// създаваме метод който да връща кораб от списъка с кораби и който ще се наследи от всички кораби
        {
            return GameEngine.Starships.First(x => x.Name == name);
        }

        protected void ValidateShipExistance(IStarship ship)
        {
            if (ship.Health<=0)
            {
                throw new ShipException(Messages.ShipAlreadyDestroyed);
            }
        }

        public abstract void Execute(string[] commandArgs);
    }
}
