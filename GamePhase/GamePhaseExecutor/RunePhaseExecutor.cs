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
            manager.CurrentPlayer.HandleRunePhase();
        }
    }
}