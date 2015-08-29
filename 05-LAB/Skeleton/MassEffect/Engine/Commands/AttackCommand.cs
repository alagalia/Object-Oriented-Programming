using System;
using MassEffect.Exceptions;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string attackerShipName = commandArgs[1];
            string targetShipName = commandArgs[2];

            var attackingShip = this.GetStarShipByName(attackerShipName);
            var targetShip = this.GetStarShipByName(targetShipName);

            this.ProcessStartShipBattle(attackingShip, targetShip);//създаваме нов метод с който сбиваме двата кораба
        }

        private void ProcessStartShipBattle(IStarship attackingShip, IStarship targetShip)
        {
            this.ValidateShipExistance(attackingShip);//проверка дали не са разрушени, т.е. не съществуват
            this.ValidateShipExistance(targetShip);

            var battleLocation = attackingShip.Location;
            if (targetShip.Location != battleLocation)
            {
                throw new ShipException(Messages.NoSuchShipInStarSystem);
            }

            //сблъсък!!!

            // създаваме обект от тип интерфейс, който има в себе си int Damage { get; set; } и  void Hit(IStarship ship);
            IProjectile attack = attackingShip.ProduceAttack();

            targetShip.RespondToAttack(attack);//мишената е ударена и има поражения

            Console.WriteLine(Messages.ShipAttacked, attackingShip.Name, targetShip.Name);//обратна връзка


            if (targetShip.Health < 0)//дали е разрушен кораба при атаката
            {
                targetShip.Health = 0;
                Console.WriteLine(Messages.ShipDestroyed, targetShip.Name);
            }

            if (targetShip.Shields < 0)
            {
                targetShip.Shields = 0;
            }
        }
    }
}
