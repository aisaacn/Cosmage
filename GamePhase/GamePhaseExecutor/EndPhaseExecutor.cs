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
            //Console.WriteLine($"Ending {manager.CurrentPlayer.Name}'s turn");
            manager.SwitchPlayer();
        }
    }
}