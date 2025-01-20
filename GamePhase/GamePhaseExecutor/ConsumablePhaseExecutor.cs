using System;

namespace CosmageV2.GamePhase
{
    /*
     * Defines default Consumable phase execution: current Player may use any number of consumables.
     * created 1/2/25
     */
    internal class ConsumablePhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public ConsumablePhaseExecutor()
        {
            Phase = GamePhase.Consumable;
        }

        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            manager.CurrentPlayer.HandleUseConsumables();
        }
    }
}