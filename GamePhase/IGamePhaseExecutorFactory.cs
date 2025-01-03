using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    internal interface IGamePhaseExecutorFactory
    {
        IGamePhaseExecutor CreateInitialPhaseExecutor();
        IGamePhaseExecutor GetNextPhaseExecutor(GamePhase currentPhase);
    }
}
