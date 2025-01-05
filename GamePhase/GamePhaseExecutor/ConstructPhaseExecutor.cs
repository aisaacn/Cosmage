using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;

namespace CosmageV2.GamePhase
{
    internal class ConstructPhaseExecutor : IGamePhaseExecutor
    {
        public GamePhase Phase { get; }

        public ConstructPhaseExecutor()
        {
            Phase = GamePhase.Construct;
        }

        public void ExecuteGamePhase(GamePhaseManager manager)
        {
            List<Construct> currentPlayerConstructs = manager.CurrentPlayer.Constructs;
            if (currentPlayerConstructs.Count > 0)
            {
                // TODO deal damage to opposing player for each construct
            }
            else
            {
                Console.WriteLine($"{manager.CurrentPlayer.Name} has no constructs");
            }
        }
    }
}