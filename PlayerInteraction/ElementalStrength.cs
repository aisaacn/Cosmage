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

        /// <summary>
        /// Returns strength of provided Element.
        /// </summary>
        public int GetStrength(Element element)
        {
            return strengths[element];
        }

        /// <summary>
        /// Adds provided strength to provided Element. Strength cannot be below 0.
        /// </summary>
        public void AddStrength(Element element, int strength)
        {
            int cur = strengths[element];
            strengths[element] = Math.Max(cur + strength, 0);
        }

        /// <summary>
        /// Removes strength from provided Element. Strength cannot be below 0.
        /// </summary>
        public void RemoveStrength(Element element, int strength)
        {
            int cur = strengths[element];
            strengths[element] = Math.Max(cur - strength, 0);
        }

        /// <summary>
        /// Add strengths for each element from provided ElementalStrength.
        /// </summary>
        public void AddStrengths(ElementalStrength strengthsToAdd)
        {
            this.AddStrength(Element.Natural, strengthsToAdd.GetStrength(Element.Natural));
            this.AddStrength(Element.Mechanical, strengthsToAdd.GetStrength(Element.Mechanical));
            this.AddStrength(Element.Unnatural, strengthsToAdd.GetStrength(Element.Unnatural));
        }

        /// <summary>
        /// Returns total strength from all Elements.
        /// </summary>
        public int GetMagnitude()
        {
            return strengths.Values.Sum();
        }

        /// <summary>
        /// Returns the Element with the largest strength, with preference to provided Element in case of ties.
        /// </summary>
        public Element GetPrimaryElementWithTiebreakerPreference(Element tiebreakerPreference)
        {
            Element primary = tiebreakerPreference;
            foreach (Element e in strengths.Keys)
            {
                if (strengths[e] > strengths[primary]) primary = e;
            }
            return primary;
        }

        /// <summary>
        /// Sets strengths for all Elements to 0.
        /// </summary>
        public void SetZero()
        {
            strengths = new Dictionary<Element, int>();

            strengths.Add(Element.Natural, 0);
            strengths.Add(Element.Mechanical, 0);
            strengths.Add(Element.Unnatural, 0);
        }

        /// <summary>
        /// Returns formatted string of each Element's strength.
        /// </summary>
        public override string ToString()
        {
            return string.Join(" ", strengths);
        }
    }
}
