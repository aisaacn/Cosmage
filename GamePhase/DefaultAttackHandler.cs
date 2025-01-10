using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    public class DefaultAttackHandler : IAttackHandler
    {
        public void HandleAttack(ElementalStrength strength, Player target)
        {
            // TODO
            Console.WriteLine($"{target.Name} has been attacked! {strength.ToString()}");
        }
    }
}
