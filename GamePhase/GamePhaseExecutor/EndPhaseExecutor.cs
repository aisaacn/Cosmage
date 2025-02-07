using System;

namespace CosmageV2.GamePhase
{
    /*
     * Defines default End phase execution: switch players
     * Created 1/8/25
     */
    internal class EndPhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public EndPhaseExecutor()
        {
            Phase = GamePhase.End;
        }

        /// <summary>
        /// Executes the End Phase, switching active players.
        /// </summary>
        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            //Console.WriteLine($"Ending {manager.CurrentPlayer.Name}'s turn");
            manager.SwitchPlayer();
        }
    }
}