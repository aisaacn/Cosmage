using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    /*
     * Facilitates attacks between Players.
     * Created 1/11/25
     */
    public interface IAttackHandler
    {
        void HandleAttack(ElementalStrength strength, Player target);
    }
}
