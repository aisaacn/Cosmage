using CosmageV2.GamePhase;
using CosmageV2.GUI;
using System.Windows.Forms;

namespace CosmageV2
{
    internal class GameRunner
    {
        static void Main()
        {
            // For different GUI, create new RulesetManager with appropriate UI handlers
            // TODO add StartScreenGui and GameBoard to IRulesetManager? Or create separate IGuiManager
            IRulesetManager rulesetManager = new DefaultRulesetManager();
            GamePhaseManager.Instance.ConfigureRuleset(rulesetManager); 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreenGui());
        }
    }
}