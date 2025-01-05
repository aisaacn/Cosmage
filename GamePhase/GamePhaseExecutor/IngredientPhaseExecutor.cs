using System;

namespace CosmageV2.GamePhase
{
    internal class IngredientPhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public IngredientPhaseExecutor()
        {
            Phase = GamePhase.Ingredient;
        }

        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            // Console.WriteLine($"executing Player {manager.CurrentPlayer.Name}'s ingredient phase");
            manager.CurrentPlayer.HandleAddIngredient();
        }
    }
}