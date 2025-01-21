using CosmageV2.GamePhase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Consumable that doubles current Player's Cauldron strength.
     * Wormhole: Halves opposing Player's Cauldron strength, rounded up.
     * Created 1/20/25
     */
    public class Augment : Consumable
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }

        public Augment()
        {
            Name = "Augment";
            SatchelWeight = 20;
        }

        public override void UseConsumable()
        {
            ElementalStrength cauldron = GamePhaseManager.Instance.CurrentPlayer.Cauldron;
            cauldron.AddStrengths(cauldron);
        }

        public override void UseConsumableWithWormhole()
        {
            ElementalStrength cauldron = GamePhaseManager.Instance.InactivePlayer.Cauldron;

            foreach (Element element in Enum.GetValues(typeof(Element)))
            {
                cauldron.RemoveStrength(element, (int) Math.Floor(cauldron.GetStrength(element) / 2.0));
            }
        }
    }
}
