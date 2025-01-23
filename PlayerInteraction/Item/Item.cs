using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction.Itemization
{
    /*
     * General type for items that belong in a Player's satchel.
     * Includes Ingredients (Essences and Catalysts), Consumables, and Passives.
     * Created 1/15/25
     */
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "itemType")]
    [JsonDerivedType(typeof(BasicNaturalEssence), "basic_natural_essence")]
    [JsonDerivedType(typeof(BasicMechanicalEssence), "basic_mechanical_essence")]
    [JsonDerivedType(typeof(BasicUnnaturalEssence), "basic_unnatural_essence")]
    [JsonDerivedType(typeof(AdvancedNaturalEssence), "advanced_natural_essence")]
    [JsonDerivedType(typeof(AdvancedMechanicalEssence), "advanced_mechanical_essence")]
    [JsonDerivedType(typeof(AdvancedUnnaturalEssence), "advanced_unnatural_essence")]
    [JsonDerivedType(typeof(AttackCrystal), "attack_catalyst")]
    [JsonDerivedType(typeof(WardCrystal), "ward_catalyst")]
    [JsonDerivedType(typeof(ConstructCrystal), "construct_catalyst")]
    [JsonDerivedType(typeof(Augment), "augment")]
    [JsonDerivedType(typeof(Fractal), "fractal")]
    [JsonDerivedType(typeof(Tesseract), "tesseract")]
    [JsonDerivedType(typeof(Wormhole), "wormhole")]
    [JsonDerivedType(typeof(AllWardTome), "all_ward_tome")]
    [JsonDerivedType(typeof(BreakWardTome), "break_ward_tome")]
    [JsonDerivedType(typeof(HastyTome), "hasty_tome")]
    [JsonDerivedType(typeof(MechanicalWardTome), "mechanical_ward_tome")]
    [JsonDerivedType(typeof(NaturalWardTome), "natural_ward_tome")]
    [JsonDerivedType(typeof(UnnaturalWardTome), "unnatural_ward_tome")]
    [JsonDerivedType(typeof(PreparatoryTome), "preparatory_tome")]
    [JsonDerivedType(typeof(SturdyTome), "sturdy_tome")]
    // TODO this violates SRP and obfuscates domain vs serialization layer. Fix with custom JsonConverter
    public abstract class Item
    {
        public abstract string Name { get; protected set; }
        public abstract int SatchelWeight { get; protected set; }
    }
}
