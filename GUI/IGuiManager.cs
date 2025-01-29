using CosmageV2.PlayerInteraction;

namespace CosmageV2.GUI
{
    public interface IGuiManager
    {
        // GameBoard Communicator for GamePhaseManager
        public IGameBoardCommunicator GameBoardCommunicator { get; protected set; }

        // Player UI Handlers
        public IAddIngredientHandler AddIngredientHandler { get; protected set; }
        public IRunePhaseHandler RunePhaseHandler { get; protected set; }
        public IConsumablePhaseHandler ConsumablePhaseHandler { get; protected set; }
        public IChooseAttackTargetHandler ChooseAttackTargetHandler { get; protected set; }
        //public StartScreenGui StartScreenGui { get; protected set; } // TODO IStartScreenGui ?
        //public GameBoardGui GameBoardGui { get; protected set; } // TODO IGameBoardGui ? or maybe these don't belong here

        public void StartApplication();
    }
}
