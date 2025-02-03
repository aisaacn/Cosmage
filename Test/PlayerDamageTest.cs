using CosmageV2.GamePhase;
using CosmageV2.GUI;
using CosmageV2.PlayerInteraction;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CosmageV2.Test
{
    public class PlayerDamageTest
    {
        [Theory] // TODO too many tests?
        [InlineData(Element.Natural, 0, 0, 0, 20)]
        [InlineData(Element.Natural, -99, -99, -99, 20)]
        [InlineData(Element.Natural, -1, -1, -1, 20)]
        [InlineData(Element.Natural, 1, 0, 0, 19)]
        [InlineData(Element.Natural, 0, 1, 0, 20)]
        [InlineData(Element.Natural, 0, 0, 1, 18)]
        [InlineData(Element.Natural, 1, 1, 1, 17)]
        [InlineData(Element.Natural, 5, 0, 0, 15)]
        [InlineData(Element.Natural, 0, 5, 0, 16)]
        [InlineData(Element.Natural, 0, 0, 5, 14)]
        [InlineData(Element.Natural, 5, 5, 5, 5)]
        [InlineData(Element.Natural, 100, 0, 0, -80)]
        [InlineData(Element.Natural, 0, 100, 0, -79)]
        [InlineData(Element.Natural, 0, 0, 100, -81)]
        [InlineData(Element.Mechanical, 0, 0, 0, 20)]
        [InlineData(Element.Mechanical, -99, -99, -99, 20)]
        [InlineData(Element.Mechanical, -1, -1, -1, 20)]
        [InlineData(Element.Mechanical, 1, 0, 0, 18)]
        [InlineData(Element.Mechanical, 0, 1, 0, 19)]
        [InlineData(Element.Mechanical, 0, 0, 1, 20)]
        [InlineData(Element.Mechanical, 1, 1, 1, 17)]
        [InlineData(Element.Mechanical, 5, 0, 0, 14)]
        [InlineData(Element.Mechanical, 0, 5, 0, 15)]
        [InlineData(Element.Mechanical, 0, 0, 5, 16)]
        [InlineData(Element.Mechanical, 5, 5, 5, 5)]
        [InlineData(Element.Mechanical, 100, 0, 0, -81)]
        [InlineData(Element.Mechanical, 0, 100, 0, -80)]
        [InlineData(Element.Mechanical, 0, 0, 100, -79)]
        [InlineData(Element.Unnatural, 0, 0, 0, 20)]
        [InlineData(Element.Unnatural, -99, -99, -99, 20)]
        [InlineData(Element.Unnatural, -1, -1, -1, 20)]
        [InlineData(Element.Unnatural, 1, 0, 0, 20)]
        [InlineData(Element.Unnatural, 0, 1, 0, 18)]
        [InlineData(Element.Unnatural, 0, 0, 1, 19)]
        [InlineData(Element.Unnatural, 1, 1, 1, 17)]
        [InlineData(Element.Unnatural, 5, 0, 0, 16)]
        [InlineData(Element.Unnatural, 0, 5, 0, 14)]
        [InlineData(Element.Unnatural, 0, 0, 5, 15)]
        [InlineData(Element.Unnatural, 5, 5, 5, 5)]
        [InlineData(Element.Unnatural, 100, 0, 0, -79)]
        [InlineData(Element.Unnatural, 0, 100, 0, -81)]
        [InlineData(Element.Unnatural, 0, 0, 100, -80)]
        public void TestPlayerDamageNoWard(Element playerElement, int nat, int mech, int un, int expected)
        {
            IRulesetManager ruleset = new DefaultRulesetManager();
            IGuiManager gui = new WinFormGuiManager();
            Player player = new Player(playerElement, "TestPlayer", ruleset, gui);
            ElementalStrength damage = new ElementalStrength(nat, mech, un);

            ruleset.AttackHandler.HandleAttack(damage, player);

            Assert.Equal(expected, player.Health);
        }

        [Theory]
        [InlineData(Element.Natural, 0, 0, 0, 20, 1, 1, 1)]
        [InlineData(Element.Natural, -99, -99, -99, 20, 1, 1, 1)]
        [InlineData(Element.Natural, -1, -1, -1, 20, 1, 1, 1)]
        [InlineData(Element.Natural, 1, 0, 0, 20, 1, 1, 0)]
        [InlineData(Element.Natural, 0, 1, 0, 20, 1, 1, 1)] // Damage reduced to 0 since Natural > Mechanical
        [InlineData(Element.Natural, 0, 0, 1, 20, 1, 0, 1)]
        [InlineData(Element.Natural, 1, 1, 1, 20, 1, 0, 0)]
        [InlineData(Element.Natural, 100, 0, 0, 20, 1, 1, 0)]
        [InlineData(Element.Natural, 0, 100, 0, 20, 0, 1, 1)]
        [InlineData(Element.Natural, 0, 0, 100, 20, 1, 0, 1)]
        [InlineData(Element.Natural, 100, 100, 100, 20, 0, 0, 0)]
        [InlineData(Element.Mechanical, 0, 0, 0, 20, 1, 1, 1)]
        [InlineData(Element.Mechanical, -99, -99, -99, 20, 1, 1, 1)]
        [InlineData(Element.Mechanical, -1, -1, -1, 20, 1, 1, 1)]
        [InlineData(Element.Mechanical, 1, 0, 0, 20, 1, 1, 0)]
        [InlineData(Element.Mechanical, 0, 1, 0, 20, 0, 1, 1)]
        [InlineData(Element.Mechanical, 0, 0, 1, 20, 1, 1, 1)] // Damage reduced to 0 since Mechanical > Unnatural
        [InlineData(Element.Mechanical, 1, 1, 1, 20, 0, 1, 0)]
        [InlineData(Element.Mechanical, 100, 0, 0, 20, 1, 1, 0)]
        [InlineData(Element.Mechanical, 0, 100, 0, 20, 0, 1, 1)]
        [InlineData(Element.Mechanical, 0, 0, 100, 20, 1, 0, 1)]
        [InlineData(Element.Mechanical, 100, 100, 100, 20, 0, 0, 0)]
        [InlineData(Element.Unnatural, 0, 0, 0, 20, 1, 1, 1)]
        [InlineData(Element.Unnatural, -99, -99, -99, 20, 1, 1, 1)]
        [InlineData(Element.Unnatural, -1, -1, -1, 20, 1, 1, 1)]
        [InlineData(Element.Unnatural, 1, 0, 0, 20, 1, 1, 1)] // Damage reduced to 0 since Unnatural > Natural
        [InlineData(Element.Unnatural, 0, 1, 0, 20, 0, 1, 1)]
        [InlineData(Element.Unnatural, 0, 0, 1, 20, 1, 0, 1)]
        [InlineData(Element.Unnatural, 1, 1, 1, 20, 0, 0, 1)]
        [InlineData(Element.Unnatural, 100, 0, 0, 20, 1, 1, 0)]
        [InlineData(Element.Unnatural, 0, 100, 0, 20, 0, 1, 1)]
        [InlineData(Element.Unnatural, 0, 0, 100, 20, 1, 0, 1)]
        [InlineData(Element.Unnatural, 100, 100, 100, 20, 0, 0, 0)]
        public void TestPlayerDamage111Ward(Element playerElement, int nat, int mech, int un, int expectedHealth, int expectedNat, int expectedMech, int expectedUn)
        {
            IRulesetManager ruleset = new DefaultRulesetManager();
            IGuiManager gui = new WinFormGuiManager();
            Player player = new Player(playerElement, "TestPlayer", ruleset, gui);
            player.AddWard(new ElementalStrength(1, 1, 1));
            ElementalStrength damage = new ElementalStrength(nat, mech, un);

            ruleset.AttackHandler.HandleAttack(damage, player);

            Assert.Equal(expectedHealth, player.Health);
            Assert.Equal(expectedNat, player.Ward.GetStrength(Element.Natural));
            Assert.Equal(expectedMech, player.Ward.GetStrength(Element.Mechanical));
            Assert.Equal(expectedUn, player.Ward.GetStrength(Element.Unnatural));
        }
    }
}
