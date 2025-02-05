using CosmageV2.PlayerInteraction;
using Xunit;

namespace CosmageV2.Test
{
    public class RuneTest
    {
        [Fact]
        public void TestRuneActivation()
        {
            Rune rune = new StandardRune();

            Assert.False(rune.IsActive);

            rune.ActivateRune();

            Assert.True(rune.IsActive);
            Assert.False(rune.ActivateRune());
            Assert.True(rune.IsActive);
        }

        [Fact]
        public void TestRuneCharge()
        {
            Rune rune = new StandardRune();

            Assert.Equal(0, rune.CurrentCharges);
            Assert.True(rune.ChargeRune());
            Assert.Equal(1, rune.CurrentCharges);
            Assert.True(rune.ChargeRune());
            Assert.Equal(2, rune.CurrentCharges);
            Assert.True(rune.ChargeRune());
            Assert.Equal(3, rune.CurrentCharges);
            Assert.True(rune.IsMaxCharge());
            Assert.False(rune.ChargeRune());
            Assert.Equal(3, rune.CurrentCharges);
            Assert.True(rune.IsMaxCharge());
        }

        [Fact]
        public void TestGetEffectByCharge()
        {
            Rune rune = new StandardRune();

            Assert.True(rune.ChargeRune());
            Assert.Equal(-1, rune.GetEffectByCharge());
            Assert.True(rune.ChargeRune());
            Assert.Equal(0, rune.GetEffectByCharge());
            Assert.True(rune.ChargeRune());
            Assert.Equal(1, rune.GetEffectByCharge());
            Assert.False(rune.ChargeRune());
            Assert.Equal(1, rune.GetEffectByCharge());
        }

        [Theory]
        [InlineData(0, int.MinValue)]
        [InlineData(1, -1)]
        [InlineData(2, 0)]
        [InlineData(3, 1)]
        public void TestDecrement(int numberOfCharges, int expectedEffect)
        {
            Rune rune = new StandardRune();

            Assert.True(rune.ActivateRune());
            for (int i = 0; i < numberOfCharges; i++) rune.ChargeRune();
            Assert.Equal(int.MinValue, rune.DecrementDelayAndReturnEffectIfDelayBecomesZero());
            Assert.Equal(expectedEffect, rune.DecrementDelayAndReturnEffectIfDelayBecomesZero());
        }
    }
}
