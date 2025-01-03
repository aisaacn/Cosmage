using System;

namespace CosmageV2.GamePhase
{
    internal class EndPhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public EndPhaseExecutor()
        {
            Phase = GamePhase.End;
        }

        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            // TODO
            Console.WriteLine($"executing Player {manager.CurrentPlayer}'s end phase");
            manager.SwitchPlayer();
        }
    }
}