using CosmageV2.PlayerInteraction;

namespace CosmageV2.GUI
{
    public interface IGameBoardCommunicator
    {
        public void ConfigurePlayers(Player player1, Player player2);
        public void UpdateCurrentPlayer(Player player);
        public void UpdatePlayerState(Player player1, Player player2);
        public void DeclareWinner(Player player);
        public void LogEvent(string log);
    }
}
