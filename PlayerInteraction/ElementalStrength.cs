using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    /*
     * Data structure to define magnitudes of each element for active spells, wards, and constructs.
     * Created 1/5/25
     */
    public class ElementalStrength
    {
        Dictionary<Element, int> strengths;

        public ElementalStrength() : this(0, 0, 0) { }

        public ElementalStrength(int natural, int mechanical, int unnatural)
        {
            strengths = new Dictionary<Element, int>();

            // TODO: probably don't hardcode this. Foreach Element in enum??
            strengths.Add(Element.Natural, Math.Max(natural, 0));
            strengths.Add(Element.Mechanical, Math.Max(mechanical, 0));
            strengths.Add(Element.Unnatural, Math.Max(unnatural, 0));
        }

        public int GetStrength(Element element)
        {
            return strengths[element];
        }

        public void AddStrength(Element element, int strength)
        {
            int cur = strengths[element];
            strengths[element] = Math.Max(cur + strength, 0);
        }

        public void RemoveStrength(Element element, int strength)
        {
            int cur = strengths[element];
            strengths[element] = Math.Max(cur - strength, 0);
        }

        public void AddStrengths(ElementalStrength strengthsToAdd)
        {
            this.AddStrength(Element.Natural, strengthsToAdd.GetStrength(Element.Natural));
            this.AddStrength(Element.Mechanical, strengthsToAdd.GetStrength(Element.Mechanical));
            this.AddStrength(Element.Unnatural, strengthsToAdd.GetStrength(Element.Unnatural));
        }

        public int GetMagnitude()
        {
            return strengths.Values.Sum();
        }

        public Element GetPrimaryElementWithTiebreakerPreference(Element tiebreakerPreference)
        {
            Element primary = tiebreakerPreference;
            foreach (Element e in strengths.Keys)
            {
                if (strengths[e] > strengths[primary]) primary = e;
            }
            return primary;
        }

        public void SetZero()
        {
            strengths = new Dictionary<Element, int>();

            strengths.Add(Element.Natural, 0);
            strengths.Add(Element.Mechanical, 0);
            strengths.Add(Element.Unnatural, 0);
        }

        public override string ToString()
        {
            return string.Join(" ", strengths);
        }
    }
}
