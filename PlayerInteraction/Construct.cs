using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public class Construct
    {
        public ElementalStrength Strength { get; private set; }

        public Construct(ElementalStrength strength)
        {
            Strength = strength;
        }
    }
}
