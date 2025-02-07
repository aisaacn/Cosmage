using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    /*
     * Handles logic for executing each game phase.
     * Created 1/2/25
     */
    public interface IGamePhaseExecutor
    {
        GamePhase Phase { get; }

        /// <summary>
        /// Executes the specified GamePhase.
        /// </summary>
        void ExecuteGamePhase(GamePhaseManager manager);
    }
}
