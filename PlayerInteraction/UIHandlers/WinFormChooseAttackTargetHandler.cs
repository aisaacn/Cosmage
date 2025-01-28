using CosmageV2.GamePhase;
using CosmageV2.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public class WinFormChooseAttackTargetHandler : IChooseAttackTargetHandler
    {
        public Targetable HandleChooseAttackTarget()
        {
            ChooseAttackTargetGui gui = new ChooseAttackTargetGui();
            gui.ShowDialog();

            return gui.Target;
        }
    }
}
