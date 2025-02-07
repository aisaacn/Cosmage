using System;
using System.Xml.Linq;
using CosmageV2.PlayerInteraction;

namespace CosmageV2.GamePhase
{
    /*
     * Defines default Execution phase: cast spell when Player's active runes reach zero delay.
     * Created 1/2/25
     */
    internal class ExecutionPhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public ExecutionPhaseExecutor()
        {
            Phase = GamePhase.Execution;
        }

        /// <summary>
        /// Executes the current Player's Execution Phase.
        /// Decrements Player's activated Runes' Delay counters by 1.
        /// If a Rune reaches 0 Delay, a spell executes using the Player's current Cauldron.
        /// </summary>
        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            // TODO
            Spell spell = manager.CurrentPlayer.HandleExecutionPhaseAndGetPreparedSpell();

            if (spell != null)
            {
                GamePhaseManager.Instance.LogEvent($"{manager.CurrentPlayer.Name} has cast a spell: {spell.Type} {spell.Strength.ToString()}");
                manager.ExecuteSpell(spell);
            }
        }
    }
}