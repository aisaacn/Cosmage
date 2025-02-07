using System;

namespace CosmageV2.GamePhase
{
    /*
     * Defines default Ingredient phase: Player adds one Ingredient to their Cauldron
     * Created 1/2/25
     */
    internal class IngredientPhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public IngredientPhaseExecutor()
        {
            Phase = GamePhase.Ingredient;
        }

        /// <summary>
        /// Executes current Player's Ingredient Phase.
        /// Player may add a single Ingredient to their Cauldron.
        /// </summary>
        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            // Console.WriteLine($"executing Player {manager.CurrentPlayer.Name}'s ingredient phase");
            manager.CurrentPlayer.HandleAddIngredient();
        }
    }
}