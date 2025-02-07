using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    /*
     * Facilitates spell effects between players.
     * Created 1/11/25
     */
    public interface ISpellExecutor
    {
        /// <summary>
        /// Handles execution of provided Spell based on it's CatalystType.
        /// </summary>
        void ExecuteSpell(Spell spell, Player caster);
    }
}
