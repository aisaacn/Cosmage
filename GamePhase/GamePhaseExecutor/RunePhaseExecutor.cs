using System;

namespace CosmageV2.GamePhase
{
    internal class RunePhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public RunePhaseExecutor()
        {
            Phase = GamePhase.Rune;
        }

        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            // TODO
            Console.WriteLine($"executing Player {manager.CurrentPlayer}'s rune phase");
        }
    }
}