using CosmageV2.GamePhase;
using CosmageV2.GUI;
using CosmageV2.PlayerInteraction;
using Xunit;

namespace CosmageV2.Test
{
    public class PlayerDamageTest
    {
        [Theory]
        [InlineData(0, 0, 0, 20)]
        [InlineData(-99, -99, -1, 20)]
        [InlineData(1, 0, 0, 19)]
        [InlineData(0, 1, 0, 20)]
        [InlineData(0, 0, 1, 18)]
        public void TestNaturalPlayerDamageNoWard(int nat, int mech, int un, int expected)
        {
            IRulesetManager ruleset = new DefaultRulesetManager();
            IGuiManager gui = new WinFormGuiManager();
            //GamePhaseManager.Instance.ConfigureRuleset(ruleset);
            //GamePhaseManager.Instance.ConfigureGui(gui);

            ElementalStrength damage = new ElementalStrength(nat, mech, un);
            Player player = new Player(Element.Natural, "TestPlayer", ruleset, gui);

            ruleset.AttackHandler.HandleAttack(damage, player);

            Assert.Equal(expected, player.Health);
        }
    }
}
