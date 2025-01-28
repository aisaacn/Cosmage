using CosmageV2.PlayerInteraction;

namespace CosmageV2.GamePhase
{
    public class DefaultRulesetManager : IRulesetManager
    {
        // Player Stats
        public int PlayerMaxHealth { get; set; } // TODO why can't set be protected?
        public int SatchelMaxWeight { get; set; }

        // Player UI Handlers //TODO move UI handlers to something like IGuiManager
        public IAddIngredientHandler AddIngredientHandler { get; set; }
        public IRunePhaseHandler RunePhaseHandler { get; set; }
        public IConsumablePhaseHandler ConsumablePhaseHandler { get; set; }
        public IChooseAttackTargetHandler ChooseAttackTargetHandler { get; set; }

        // Player Logic Handlers
        public IElementalRelationshipManager ElementalRelationshipManager { get; set; }
        public IDamageHandler DamageHandler { get; set; }
        public IWardHandler WardHandler { get; set; }

        // GamePhaseManager Logic Handlers
        public IGamePhaseExecutorFactory GamePhaseExecutorFactory { get; set; }
        public ISpellExecutor SpellExecutor { get; set; }
        public IAttackHandler AttackHandler { get; set; }
        public IPassiveHandler PassiveHandler { get; set; }

        public DefaultRulesetManager()
        {
            PlayerMaxHealth = 20;
            SatchelMaxWeight = 150;

            AddIngredientHandler = new WinFormCustomSatchelAddIngredientHandler();
            RunePhaseHandler = new WinFormRunePhaseHandler();
            ConsumablePhaseHandler = new WinFormConsumablePhaseHandler();
            ChooseAttackTargetHandler = new WinFormChooseAttackTargetHandler();

            ElementalRelationshipManager = new DefaultElementalRelationshipManager();
            DamageHandler = new DefaultDamageHandler(ElementalRelationshipManager);
            WardHandler = new DefaultWardHandler(ElementalRelationshipManager);

            GamePhaseExecutorFactory = new DefaultGamePhaseExecutorFactory();
            SpellExecutor = new DefaultSpellExecutor();
            AttackHandler = new DefaultAttackHandler();
            PassiveHandler = new DefaultPassiveHandler();
        }
    }
}
