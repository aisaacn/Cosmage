﻿using CosmageV2.GamePhase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public class WinFormGameBoardUpdater : IGameBoardUpdater
    {
        void IGameBoardUpdater.UpdateCauldron(Player player)
        {
            GamePhaseManager.Instance.GameBoard.UpdatePlayerLabels(player);
        }
    }
}
