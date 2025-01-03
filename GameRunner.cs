using CosmageV2.GamePhase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2
{
    internal class GameRunner
    {
        static void Main()
        {
            GamePhaseManager manager = GamePhaseManager.Instance;
            manager.StartGame();
        }
    }
}
