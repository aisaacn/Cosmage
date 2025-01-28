using CosmageV2.GamePhase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Consumable item that duplicates the last Essence added to the Player's Cauldron.
     * Wormhole: Removes last Essence from opposing Player's Cauldron.
     * Created 1/20/25
     */
    public class Fractal : Consumable
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override string Tooltip { get; protected set; }

        public Fractal()
        {
            Name = "Fractal";
            SatchelWeight = 20;
            Tooltip = "Consumable item that duplicates the last Essence added to the Player's Cauldron\r\n\r\nWormhole: Removes last Essence from opposing Player's Cauldron";
        }

        public override void UseConsumable()
        {
            // TODO consider for each Consumable: is it better to implement a method in Player to handle this functionality, or try to keep it contained here?
            // This way feels somewhat hacky, but I also see value in not modifying the Player class to support every possible Consumable
            Player currentPlayer = GamePhaseManager.Instance.CurrentPlayer;
            Essence lastEssence = currentPlayer.LastEssence;

            if (lastEssence != null )
                currentPlayer.Cauldron.AddStrength(lastEssence.Element, lastEssence.Magnitude);
        }

        public override void UseConsumableWithWormhole()
        {
            Player targetPlayer = GamePhaseManager.Instance.InactivePlayer;
            Essence lastEssence = targetPlayer.LastEssence;

            if (lastEssence != null)
                targetPlayer.Cauldron.RemoveStrength(lastEssence.Element, lastEssence.Magnitude);
        }
    }
}
