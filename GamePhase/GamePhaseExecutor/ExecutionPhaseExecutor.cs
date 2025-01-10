using System;
using CosmageV2.PlayerInteraction;

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
            Spell spell = manager.CurrentPlayer.HandleExecutionPhaseAndGetPreparedSpell();

            if (spell != null)
            {
                manager.ExecuteSpell(spell);
            }
        }
    }
}