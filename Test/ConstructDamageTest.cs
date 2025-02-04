using CosmageV2.GamePhase;
using CosmageV2.PlayerInteraction;
using Xunit;

namespace CosmageV2.Test
{
    public class ConstructDamageTest
    {
        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0, 0, 0, 0)]
        [InlineData(0, 0, 0, 100, 100, 100, 0, 0, 0)]
        [InlineData(1, 1, 1, 0, 0, 0, 1, 1, 1)]
        [InlineData(1, 1, 1, 100, 100, 100, 0, 0, 0)]
        [InlineData(1, 0, 0, 1, 0, 0, 0, 0, 0)]
        [InlineData(1, 0, 0, 0, 1, 0, 0, 0, 0)]
        [InlineData(1, 0, 0, 0, 0, 1, 0, 0, 0)]
        [InlineData(0, 1, 0, 1, 0, 0, 0, 0, 0)]
        [InlineData(0, 1, 0, 0, 1, 0, 0, 0, 0)]
        [InlineData(0, 1, 0, 0, 0, 1, 0, 0, 0)]
        [InlineData(0, 0, 1, 1, 0, 0, 0, 0, 0)]
        [InlineData(0, 0, 1, 0, 1, 0, 0, 0, 0)]
        [InlineData(0, 0, 1, 0, 0, 1, 0, 0, 0)]
        public void TestConstructDamage(int conNat, int conMech, int conUn, int dmgNat, int dmgMech, int dmgUn, int exNat, int exMech, int exUn)
        {
            IRulesetManager ruleset = new DefaultRulesetManager();
            ElementalStrength strength = new ElementalStrength(conNat, conMech, conUn);
            Construct construct = new Construct(strength, Element.Natural, ruleset.WardHandler);
            ElementalStrength damage = new ElementalStrength(dmgNat, dmgMech, dmgUn);

            ruleset.AttackHandler.HandleAttack(damage, construct);

            Assert.Equal(exNat, construct.Strength.GetStrength(Element.Natural));
            Assert.Equal(exMech, construct.Strength.GetStrength(Element.Mechanical));
            Assert.Equal(exUn, construct.Strength.GetStrength(Element.Unnatural));
        }
    }
}
