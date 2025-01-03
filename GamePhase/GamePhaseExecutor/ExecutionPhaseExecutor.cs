using System;

namespace CosmageV2.GamePhase
{
    internal class ExecutionPhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public ExecutionPhaseExecutor()
        {
            Phase = GamePhase.Execution;
        }

        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            // TODO
            Console.WriteLine($"executing Player {manager.CurrentPlayer.Name}'s execution phase");
        }
    }
}