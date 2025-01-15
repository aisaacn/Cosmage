using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    /*
     * Creates appropriate executor for each game phase. Defines game phase order.
     * Created 1/2/25
     */
    internal interface IGamePhaseExecutorFactory
    {
        IGamePhaseExecutor CreateInitialPhaseExecutor();
        IGamePhaseExecutor GetNextPhaseExecutor(GamePhase currentPhase);
    }
}
