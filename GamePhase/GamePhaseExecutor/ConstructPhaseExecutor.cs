using System;

namespace CosmageV2.GamePhase
{
    internal class ConstructPhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public ConstructPhaseExecutor()
        {
            Phase = GamePhase.Construct;
        }

        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            // TODO
            Console.WriteLine($"executing Player {manager.CurrentPlayer}'s construct phase");
        }
    }
}