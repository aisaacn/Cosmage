using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Facilitates Rune charge and activation on Player's turn.
     * Created 1/7/25
     */
    public interface IRunePhaseHandler
    {
        void HandleRunePhase(Player player);
    }
}
