using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    /*
     * Default game phase order and executors.
     * Created 1/2/25
     */
    public class DefaultGamePhaseExecutorFactory : IGamePhaseExecutorFactory
    {
        /// <summary>
        /// Returns the GamePhaseExecutor for the first phase (Ingredient phase).
        /// </summary>
        public IGamePhaseExecutor CreateInitialPhaseExecutor()
        {
            return new IngredientPhaseExecutor();
        }

        /// <summary>
        /// Returns the GamePhaseExecutor for the phase following the current phase.
        /// Phase Order: Ingredient, Consumable, Rune, Execution, Construct, End
        /// </summary>
        public IGamePhaseExecutor GetNextPhaseExecutor(GamePhase currentPhase)
        {
            switch (currentPhase)
            {
                case GamePhase.Ingredient:
                    return new ConsumablePhaseExecutor();

                case GamePhase.Consumable:
                    return new RunePhaseExecutor();

                case GamePhase.Rune:
                    return new ExecutionPhaseExecutor();

                case GamePhase.Execution:
                    return new ConstructPhaseExecutor();

                case GamePhase.Construct:
                    return new EndPhaseExecutor();

                case GamePhase.End:
                    return new IngredientPhaseExecutor();

                default:
                    throw new Exception($"Unknown game phase: {currentPhase}");
            }
        }
    }
}
