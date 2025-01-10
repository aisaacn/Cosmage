using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    public class DefaultSpellExecutor : ISpellExecutor
    {
        GamePhaseManager manager;

        public DefaultSpellExecutor(GamePhaseManager gpm)
        {
            manager = gpm;
        }

        public void ExecuteSpell(Spell spell)
        {
            // TODO switch on spell.Type
            Console.WriteLine($"Executing spell: {spell.Strength.ToString()} {spell.Type}");
        }
    }
}
