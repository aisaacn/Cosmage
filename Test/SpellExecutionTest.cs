using CosmageV2.GamePhase;
using CosmageV2.GUI;
using CosmageV2.PlayerInteraction;
using Xunit;

namespace CosmageV2.Test
{
    public class SpellExecutionTest
    {
        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0, 0, 0, 0)]
        [InlineData(0, 0, 0, 1, 1, 1, 1, 1, 1)]
        [InlineData(1, 1, 1, 0, 0, 0, 1, 1, 1)]
        [InlineData(1, 0, 0, 0, 0, 0, 1, 0, 0)]
        [InlineData(0, 1, 0, 0, 0, 0, 0, 1, 0)]
        [InlineData(0, 0, 1, 0, 0, 0, 0, 0, 1)]
        [InlineData(1, 0, 0, 1, 1, 1, 2, 1, 1)]
        [InlineData(0, 1, 0, 1, 1, 1, 1, 2, 1)]
        [InlineData(0, 0, 1, 1, 1, 1, 1, 1, 2)]
        [InlineData(-1, -1, -1, 0, 0, 0, 0, 0, 0)] // Negative values cannot exist in ElementalStrength. Therefore, negative values should not affect Ward.
        [InlineData(-1, -1, -1, 1, 1, 1, 1, 1, 1)]
        public void AddWardTest(int nat, int mech, int un, int initNat, int initMech, int initUn, int exNat, int exMech, int exUn)
        {
            IRulesetManager ruleset = new DefaultRulesetManager();
            IGuiManager gui = new WinFormGuiManager();
            Player player = new Player(Element.Natural, "TestPlayer", ruleset, gui);
            ElementalStrength initWard = new ElementalStrength(initNat, initMech, initUn);
            player.AddWard(initWard);
            ElementalStrength strength = new ElementalStrength(nat, mech, un);
            Spell spell = new Spell(strength, CatalystType.Ward);

            ruleset.SpellExecutor.ExecuteSpell(spell, player);

            Assert.Equal(exNat, player.Ward.GetStrength(Element.Natural));
            Assert.Equal(exMech, player.Ward.GetStrength(Element.Mechanical));
            Assert.Equal(exUn, player.Ward.GetStrength(Element.Unnatural));
        }

        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0, 0)]
        [InlineData(1, 1, 1, 1, 1, 1, 1)]
        [InlineData(5, 0, 0, 1, 5, 0, 0)]
        [InlineData(0, 5, 0, 1, 0, 5, 0)]
        [InlineData(0, 0, 5, 1, 0, 0, 5)]
        [InlineData(100, 100, 100, 1, 100, 100, 100)]
        [InlineData(-1, -1, -1, 0, 0, 0, 0)]
        [InlineData(-5, 0, 5, 1, 0, 0, 5)]
        public void AddConstructTest(int nat, int mech, int un, int exCount, int exNat, int exMech, int exUn)
        {
            IRulesetManager ruleset = new DefaultRulesetManager();
            IGuiManager gui = new WinFormGuiManager();
            Player player = new Player(Element.Natural, "TestPlayer", ruleset, gui);
            ElementalStrength strength = new ElementalStrength(nat, mech, un);
            Spell spell = new Spell(strength, CatalystType.Construct);

            ruleset.SpellExecutor.ExecuteSpell(spell, player);

            Assert.Equal(exCount, player.Constructs.Count);
            if (exCount > 0)
            {
                Assert.Equal(exNat, player.Constructs[0].Strength.GetStrength(Element.Natural));
                Assert.Equal(exMech, player.Constructs[0].Strength.GetStrength(Element.Mechanical));
                Assert.Equal(exUn, player.Constructs[0].Strength.GetStrength(Element.Unnatural));
            }
        }
    }
}
