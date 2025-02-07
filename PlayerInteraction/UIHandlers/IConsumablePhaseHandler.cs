using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public interface IConsumablePhaseHandler
    {
        /// <summary>
        /// Prompts Player to use any number of Consumables from their Satchel.
        /// </summary>
        void HandleConsumablePhase(Player player);
    }
}
