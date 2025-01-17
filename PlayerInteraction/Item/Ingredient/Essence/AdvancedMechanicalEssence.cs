using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Adds 2 Mechanical strength to Cauldron.
     * Created 1/15/25
     */
    public class AdvancedMechanicalEssence : Essence
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override Element Element { get; protected set; }
        public override int Magnitude { get; protected set; }

        public AdvancedMechanicalEssence()
        {
            Name = "Advanced Mechanical Essence";
            SatchelWeight = 10;
            Element = Element.Mechanical;
            Magnitude = 2;
        }

        public override void AddToCauldron()
        {

        }
    }
}
