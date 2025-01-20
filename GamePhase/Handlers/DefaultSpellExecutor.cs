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
        public void ExecuteSpell(Spell spell)
        {
            //Console.WriteLine($"Executing spell: {spell.Strength.ToString()} {spell.Type}");
            
            GamePhaseManager manager = GamePhaseManager.Instance;
            switch (spell.Type)
            {
                case CatalystType.Attack:
                    manager.HandleAttack(spell.Strength);
                    break;

                case CatalystType.Ward:
                    manager.CurrentPlayer.AddWard(spell.Strength);
                    break;

                case CatalystType.Construct:
                    manager.CurrentPlayer.AddConstruct(spell.Strength);
                    break;

                case CatalystType.None:
                    throw new Exception("Spell cast with no catalyst");
            }
        }
    }
}
