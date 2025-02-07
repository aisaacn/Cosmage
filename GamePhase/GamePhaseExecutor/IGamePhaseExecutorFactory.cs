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
    public interface IGamePhaseExecutorFactory
    {
        /// <summary>
        /// Returns the GamePhaseExecutor for the first phase in a game (default: Ingredient phase).
        /// </summary>
        IGamePhaseExecutor CreateInitialPhaseExecutor();

        /// <summary>
        /// Returns the GamePhaseExecutor for the phase that follows the provided phase.
        /// </summary>
        IGamePhaseExecutor GetNextPhaseExecutor(GamePhase currentPhase);
    }
}
