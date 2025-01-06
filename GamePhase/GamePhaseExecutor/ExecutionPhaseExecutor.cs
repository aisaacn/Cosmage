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
            if (manager.CurrentPlayer.IsSpellReadyToCast())
            {
                // TODO cast spell and modify game state as necessary
            }
            else
            {
                // Console.WriteLine($"{manager.CurrentPlayer.Name} is not ready to cast a spell");
            }
        }
    }
}