using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.PlayerInteraction
{
    public interface IChooseAttackTargetHandler
    {
        /// <summary>
        /// Prompts user to choose a Target (opposing Player or their Construct) for their attack Spell.
        /// Defaults to opposing Player if that Player has no Constructs.
        /// </summary>
        public Targetable HandleChooseAttackTarget();
    }
}
