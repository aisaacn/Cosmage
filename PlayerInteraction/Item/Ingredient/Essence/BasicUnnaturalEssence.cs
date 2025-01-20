using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * Adds 1 Unnatural strength to Cauldron.
     * Created 1/15/25
     */
    public class BasicUnnaturalEssence : Essence
    {
        public override string Name { get; protected set; }
        public override int SatchelWeight { get; protected set; }
        public override Element Element { get; protected set; }
        public override int Magnitude { get; protected set; }

        public BasicUnnaturalEssence()
        {
            Name = "Basic Unnatural Essence";
            SatchelWeight = 5;
            Element = Element.Unnatural;
            Magnitude = 1;
        }
    }
}
