using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Adds 1 Mechanical strength to Cauldron.
     * Created 1/15/25
     */
    public class BasicMechanicalEssence : Essence
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override Element Element { get; protected set; }
        public override int Magnitude { get; protected set; }
        public override string Tooltip { get; protected set; }

        public BasicMechanicalEssence()
        {
            Name = "Basic Mechanical Essence";
            SatchelWeight = 5;
            Element = Element.Mechanical;
            Magnitude = 1;
            Tooltip = "Adds 1 Mechanical strength to Cauldron.";
        }
    }
}
