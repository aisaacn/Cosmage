using CosmageV2.PlayerInteraction;
using System.Windows.Forms;

namespace CosmageV2.GUI
{
    public class WinFormGameBoardCommunicator : IGameBoardCommunicator
    {
        private GameBoardGui gameBoard; // TODO need some way to set this. From StartScreenGui?

        public void SetGameBoard(GameBoardGui gb)
        {
            gameBoard = gb;
        }

        public void ConfigurePlayers(Player player1, Player player2)
        {
            gameBoard.Invoke((MethodInvoker) delegate
            {
                gameBoard.AssignPlayersToLabels(player1, player2);
            });
        }

        public void DeclareWinner(Player winner)
        {
            gameBoard.Invoke((MethodInvoker) delegate
            {
                gameBoard.ShowWinner(winner);
            });
        }

        public void LogEvent(string log)
        {
            gameBoard.Invoke((MethodInvoker) delegate
            {
                gameBoard.LogEvent(log);
            });
        }

        public void UpdateCurrentPlayer(Player currentPlayer)
        {
            gameBoard.Invoke((MethodInvoker) delegate
            {
                gameBoard.UpdateCurrentPlayer(currentPlayer);
            });
        }

        public void UpdatePlayerState(Player player1, Player player2)
        {
            gameBoard.Invoke((MethodInvoker) delegate
            {
                gameBoard.UpdatePlayerLabels(player1);
                gameBoard.UpdatePlayerLabels(player2);
            });
        }
    }
}
