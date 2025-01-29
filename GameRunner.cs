using CosmageV2.GamePhase;
using CosmageV2.GUI;

namespace CosmageV2
{
    internal class GameRunner
    {
        static void Main()
        {
            // For different Ruleset, create new RulesetManager with appropriate logic 
            IRulesetManager rulesetManager = new DefaultRulesetManager();
            GamePhaseManager.Instance.ConfigureRuleset(rulesetManager);

            // For different GUIs, create new GuiManager with appropriate GUI handlers
            IGuiManager guiManager = new WinFormGuiManager();
            GamePhaseManager.Instance.ConfigureGui(guiManager);

            guiManager.StartApplication();            
        }
    }
}