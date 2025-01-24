using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmageV2.PlayerInteraction.Itemization
{
    public static class ItemRegistry
    {
        public static class Essences
        {
            public static readonly Essence BasicNaturalEssence = new BasicNaturalEssence();
            public static readonly Essence BasicMechanicalEssence = new BasicMechanicalEssence();
            public static readonly Essence BasicUnnaturalEssence = new BasicUnnaturalEssence();
            public static readonly Essence AdvancedNaturalEssence = new AdvancedNaturalEssence();
            public static readonly Essence AdvancedMechanicalEssence = new AdvancedMechanicalEssence();
            public static readonly Essence AdvancedUnnaturalEssence = new AdvancedUnnaturalEssence();

            public static readonly List<Essence> Options = new List<Essence>()
            {
                BasicNaturalEssence, BasicMechanicalEssence, BasicUnnaturalEssence,
                AdvancedNaturalEssence, AdvancedMechanicalEssence, AdvancedUnnaturalEssence
            };
        }

        public static class Catalysts
        {
            public static readonly Catalyst AttackCrystal = new AttackCrystal();
            public static readonly Catalyst WardCrystal = new WardCrystal();
            public static readonly Catalyst ConstructCrystal = new ConstructCrystal();

            public static readonly List<Catalyst> Options = new List<Catalyst>()
            {
                AttackCrystal, WardCrystal, ConstructCrystal
            };
        }

        public static class Consumables
        {
            public static readonly Consumable Fractal = new Fractal();
            public static readonly Consumable Augment = new Augment();
            public static readonly Consumable Tesseract = new Tesseract();
            public static readonly Consumable Wormhole = new Wormhole();

            public static readonly List<Consumable> Options = new List<Consumable>()
            {
                Fractal, Augment, Tesseract, Wormhole
            };
        }

        public static class PassiveItems
        {
            public static readonly PassiveItem HastyTome = new HastyTome();
            public static readonly PassiveItem SturdyTome = new SturdyTome();
            public static readonly PassiveItem PreparatoryTome = new PreparatoryTome();
            public static readonly PassiveItem NaturalWardTome = new NaturalWardTome();
            public static readonly PassiveItem MechanicalWardTome = new MechanicalWardTome();
            public static readonly PassiveItem UnnaturalWardTome = new UnnaturalWardTome();
            public static readonly PassiveItem AllWardTome = new AllWardTome();
            public static readonly PassiveItem BreakWardTome = new BreakWardTome();

            public static readonly List<PassiveItem> Options = new List<PassiveItem>()
            {
                HastyTome, SturdyTome, PreparatoryTome,
                NaturalWardTome, MechanicalWardTome, UnnaturalWardTome, AllWardTome, BreakWardTome
            };
        }
    }
}
