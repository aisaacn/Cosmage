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
        /// <summary>
        /// Prompts user to add 1 Charge to any Rune and activate 1 Rune (or none).
        /// </summary>
        void HandleRunePhase(Player player);
    }
}
