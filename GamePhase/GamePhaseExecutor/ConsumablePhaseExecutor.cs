using System;

namespace CosmageV2.GamePhase
{
    internal class ConsumablePhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public ConsumablePhaseExecutor()
        {
            Phase = GamePhase.Consumable;
        }

        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            // TODO
            Console.WriteLine($"executing Player {manager.CurrentPlayer.Name}'s consumable phase");
        }
    }
}