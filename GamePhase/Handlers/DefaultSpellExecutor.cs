using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    /*
     * Handles default spell execution.
     * Created 1/11/25
     */
    public class DefaultSpellExecutor : ISpellExecutor
    {
        /// <summary>
        /// Handles execution of provided Spell based on it's CatalystType.
        /// </summary>
        public void ExecuteSpell(Spell spell, Player caster)
        {
            //Console.WriteLine($"Executing spell: {spell.Strength.ToString()} {spell.Type}");
            
            GamePhaseManager manager = GamePhaseManager.Instance;
            switch (spell.Type)
            {
                case CatalystType.Attack:
                    manager.HandlePlayerAttack(spell.Strength);
                    break;

                case CatalystType.Ward:
                    caster.AddWard(spell.Strength);
                    break;

                case CatalystType.Construct:
                    if (spell.Strength.GetMagnitude() > 0) caster.AddConstruct(spell.Strength);
                    break;

                case CatalystType.None:
                    throw new Exception("Spell cast with no catalyst"); // Should never happen
            }
        }
    }
}
