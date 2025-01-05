using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    // Data structure to define magnitudes of each element for active spells, wards, and constructs.
    internal class ElementalStrength
    {
        Dictionary<Element, int> strengths;

        public ElementalStrength() 
        {
            strengths = new Dictionary<Element, int>();

            // TODO: probably don't hardcode this. Foreach Element in enum??
            strengths.Add(Element.Natural, 0);
            strengths.Add(Element.Mechanical, 0);
            strengths.Add(Element.Unnatural, 0);
        }

        public int GetStrength(Element element)
        {
            return strengths[element];
        }

        public void AddStrength(Element element, int strength)
        {
            int cur = strengths[element];
            strengths[element] = cur + strength;
        }

        public override string ToString()
        {
            return string.Join(" ", strengths);
        }
    }
}
