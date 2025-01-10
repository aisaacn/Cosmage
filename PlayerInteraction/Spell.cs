using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public class Spell
    {
        public ElementalStrength Strength { get; private set; }
        public CatalystType Type { get; private set; }

        public Spell(ElementalStrength strength, CatalystType type)
        {
            Strength = strength;
            Type = type;
        }
    }
}
