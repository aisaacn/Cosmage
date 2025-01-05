using System;

namespace CosmageV2.GamePhase
{
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