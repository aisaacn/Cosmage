

using CosmageV2.GUI;
using CosmageV2.PlayerInteraction;
using System;

namespace CosmageV2.GamePhase
{
    public class DefaultGameValidator : IGameValidator
    {
        public void ValidateGame(GamePhaseManager manager)
        {
            // TODO extract to something like IGameValidator?
            if (manager.Player1 is null || manager.Player2 is null)
                throw new Exception("Players must be added to GamePhaseManager before starting game.");
            ValidateSatchel(manager.Player1, manager.RulesetManager.SatchelMaxWeight);
            ValidateSatchel(manager.Player2, manager.RulesetManager.SatchelMaxWeight);

            if (manager.RulesetManager is null)
                throw new Exception("RulesetManager must be configured before starting game.");

            if (manager.GuiManager is null)
                throw new Exception("GuiManager must be configured before starting game.");
        }

        private void ValidateSatchel(Player player, int maxWeight)
        {
            if (player.Satchel.TotalWeight > maxWeight)
                throw new Exception($"{player.Name}'s Satchel exceeds the Satchel weight limit of {maxWeight}");
        }
    }
}
