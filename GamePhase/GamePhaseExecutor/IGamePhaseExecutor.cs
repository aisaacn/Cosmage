using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    internal interface IGamePhaseExecutor
    {
        GamePhase Phase { get; }
        void ExecuteGamePhase(GamePhaseManager manager);
    }
}
