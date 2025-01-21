using System;

namespace CosmageV2.GamePhase
{
    /*
     * Prompts current Player to handle their Rune phase.
     * Created 1/2/25
     */
    internal class RunePhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public RunePhaseExecutor()
        {
            Phase = GamePhase.Rune;
        }

        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            if (manager.CurrentTurn != 0 || manager.CurrentPlayer.Prepared)
                manager.CurrentPlayer.HandleRunePhase();
        }
    }
}