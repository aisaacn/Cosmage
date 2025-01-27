using CosmageV2.GamePhase;
using CosmageV2.GUI;
using CosmageV2.PlayerInteraction.Itemization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public class WinFormConsumablePhaseHandler : IConsumablePhaseHandler
    {
        private bool usingWormhole = false;

        public void HandleConsumablePhase(Player player)
        {
            if (player.Satchel.Consumables.Count == 0)
            {
                //Console.WriteLine($"{player.Name} has no Consumables");
                return;
            }

            ConsumablePhaseGui gui = new ConsumablePhaseGui(player.Satchel.Consumables);
            gui.ShowDialog();

            Consumable consumable = gui.selectedConsumable;
            if (consumable != null)
                UseConsumable(player, consumable);
            
            if (!gui.isFinished)
                HandleConsumablePhase(player);
        }

        private void UseConsumable(Player player, Consumable consumable)
        {
            player.RemoveConsumableFromSatchel(consumable);

            if (consumable.Name.Equals("Wormhole"))
            {
                if (!usingWormhole)
                {
                    usingWormhole = true;
                    return;
                }
                
            }

            // TODO consider player.UseConsumableAndRemove(consumable);
            consumable.UseConsumable(usingWormhole);
            usingWormhole = false;
            GamePhaseManager.Instance.LogEvent($"{player.Name} used {consumable.Name}"); // TODO potentially move to Player
            GamePhaseManager.Instance.UpdateGameBoard();
        }
    }
}
