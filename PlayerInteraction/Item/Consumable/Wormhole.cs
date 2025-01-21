using CosmageV2.GamePhase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Consumable item that modifies other Consumables to instead affect opposing Player
     * Created 1/20/25
     */
    public class Wormhole : Consumable
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }

        public Wormhole()
        {
            Name = "Wormhole";
            SatchelWeight = 10; // TODO probably way too cheap
        }

        public override void UseConsumable()
        {
            // This should never be called
            throw new NotImplementedException();
        }

        public override void UseConsumableWithWormhole()
        {
            GamePhaseManager.Instance.CurrentPlayer.Satchel.AddItem(ItemRegistry.Consumables.Wormhole);
            GamePhaseManager.Instance.CurrentPlayer.Satchel.AddItem(ItemRegistry.Consumables.Wormhole);
        }
    }
}
