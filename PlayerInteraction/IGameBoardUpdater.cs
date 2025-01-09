using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public interface IGameBoardUpdater
    {
        void UpdateLabels(Player player);
    }
}
