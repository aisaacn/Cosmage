using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    internal class DefaultGamePhaseExecutorFactory : IGamePhaseExecutorFactory
    {
        public IGamePhaseExecutor CreateInitialPhaseExecutor()
        {
            return new IngredientPhaseExecutor();
        }

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
