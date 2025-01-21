using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    public static class ItemRegistry
    {
        public static class Essences
        {
            public static readonly Essence BasicNatural = new BasicNaturalEssence();
            public static readonly Essence BasicMechanical = new BasicMechanicalEssence();
            public static readonly Essence BasicUnnatural = new BasicUnnaturalEssence();
            public static readonly Essence AdvancedNatural = new AdvancedNaturalEssence();
            public static readonly Essence AdvancedMechanical = new AdvancedMechanicalEssence();
            public static readonly Essence AdvancedUnnatural = new AdvancedUnnaturalEssence();
        }

        public static class Catalysts
        {
            public static readonly Catalyst Attack = new AttackCrystal();
            public static readonly Catalyst Ward = new WardCrystal();
            public static readonly Catalyst Construct = new ConstructCrystal();
        }

        public static class Consumables
        {
            public static readonly Consumable Fractal = new Fractal();
            public static readonly Consumable Tesseract = new Tesseract();
            public static readonly Consumable Augment = new Augment();
            public static readonly Consumable Wormhole = new Wormhole();
        }

        public static class PassiveItems { } // TODO
    }
}
