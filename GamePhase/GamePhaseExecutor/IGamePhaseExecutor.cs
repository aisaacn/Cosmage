﻿using System;
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
    internal interface IGamePhaseExecutor
    {
        GamePhase Phase { get; }
        void ExecuteGamePhase(GamePhaseManager manager);
    }
}
