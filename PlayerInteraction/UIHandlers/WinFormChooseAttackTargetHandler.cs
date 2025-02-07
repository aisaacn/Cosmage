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
        /// <summary>
        /// Launches Windows Forms GUI to select a target for Player's attack Spell.
        /// Defaults to opposing Player if that Player has no Constructs.
        /// </summary>
        public Targetable HandleChooseAttackTarget()
        {
            Player inactivePlayer = GamePhaseManager.Instance.InactivePlayer;
            if (inactivePlayer.Constructs.Count == 0)
            {
                return inactivePlayer;
            }

            ChooseAttackTargetGui gui = new ChooseAttackTargetGui();
            gui.ShowDialog();

            return gui.Target;
        }
    }
}
