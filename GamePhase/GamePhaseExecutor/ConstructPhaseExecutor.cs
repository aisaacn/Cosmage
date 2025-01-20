using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;
using System.Windows.Media.Animation;

namespace CosmageV2.GamePhase
{
    /*
     * Default execution of Construct phase: all current Constructs attack and then lose 1 strength of each element.
     * Created 1/2/25
     */
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
                foreach (Construct c in currentPlayerConstructs)
                {
                    if (!c.HasSummoningSickness)
                    {
                        manager.HandleAttack(c.Strength);
                    }
                }
                manager.CurrentPlayer.DecrementAllConstructs();
            }
        }
    }
}