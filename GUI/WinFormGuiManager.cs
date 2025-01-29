using CosmageV2.PlayerInteraction;
using System.Windows.Forms;

namespace CosmageV2.GUI
{
    public class WinFormGuiManager : IGuiManager
    {
        public IGameBoardCommunicator GameBoardCommunicator { get; set; }
        public IAddIngredientHandler AddIngredientHandler { get; set; }
        public IRunePhaseHandler RunePhaseHandler { get; set; }
        public IConsumablePhaseHandler ConsumablePhaseHandler { get; set; }
        public IChooseAttackTargetHandler ChooseAttackTargetHandler { get; set; }
        public StartScreenGui StartScreen { get; set; }
        public GameBoardGui GameBoard { get; set; }

        public WinFormGuiManager()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AddIngredientHandler = new WinFormCustomSatchelAddIngredientHandler();
            RunePhaseHandler = new WinFormRunePhaseHandler();
            ConsumablePhaseHandler = new WinFormConsumablePhaseHandler();
            ChooseAttackTargetHandler = new WinFormChooseAttackTargetHandler();

            GameBoard = new GameBoardGui();
            StartScreen = new StartScreenGui(GameBoard);
            GameBoardCommunicator = new WinFormGameBoardCommunicator();
            ((WinFormGameBoardCommunicator) GameBoardCommunicator).SetGameBoard(GameBoard); // TODO better way to set GameBoard
        }

        public void StartApplication()
        {
            Application.Run(StartScreen);
        }
    }
}
