using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    public interface IRulesetManager
    {
        // Player Stats
        public int PlayerMaxHealth { get; protected set; }
        public int SatchelMaxWeight { get; protected set; }

        // Player UI Handlers
        public IAddIngredientHandler AddIngredientHandler { get; protected set; }
        public IRunePhaseHandler RunePhaseHandler { get; protected set; }
        public IConsumablePhaseHandler ConsumablePhaseHandler { get; protected set; }
        public IChooseAttackTargetHandler ChooseAttackTargetHandler { get; protected set; }

        // Player Logic Handlers
        public IElementalRelationshipManager ElementalRelationshipManager { get; protected set; }
        public IDamageHandler DamageHandler { get; protected set; }
        public IWardHandler WardHandler { get; protected set; }

        // GamePhaseManager Logic Handlers
        public IGamePhaseExecutorFactory GamePhaseExecutorFactory { get; protected set; }
        public ISpellExecutor SpellExecutor { get; protected set; }
        public IAttackHandler AttackHandler { get; protected set; }
        public IPassiveHandler PassiveHandler { get; protected set; }
    }
}
