using CosmageV2.PlayerInteraction;
using CosmageV2.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmageV2.GamePhase
{
    /*
     * Facilitates gameplay cycle and Player interaction. Communicates with GUI to reflect gamestate.
     * Created 1/1/25
     */
    public class GamePhaseManager
    {
        // TODO: reconsider lazy instantiation (it's just so easy)
        private static readonly Lazy<GamePhaseManager> lazy =
            new Lazy<GamePhaseManager>(() => new GamePhaseManager());
        public static GamePhaseManager Instance { get { return lazy.Value; } }

        private IGamePhaseExecutor currentPhaseExecutor;
        private IGamePhaseExecutorFactory gamePhaseExecutorFactory;
        private ISpellExecutor spellExecutor;
        private IAttackHandler attackHandler;

        Player player1;
        Player player2;
        public Player CurrentPlayer { get; private set; }
        public Player InactivePlayer { get; private set; }
        public int CurrentTurn { get; private set; }
        public GameBoardGui GameBoard { get; private set; }

        private GamePhaseManager()
        {
            SetupGamePhaseManager();
        }

        private void SetupGamePhaseManager()
        {
            //CreatePlayers();
            //ConfigureGameBoard();
            CurrentTurn = 0;

            gamePhaseExecutorFactory = new DefaultGamePhaseExecutorFactory();
            currentPhaseExecutor = gamePhaseExecutorFactory.CreateInitialPhaseExecutor();
            spellExecutor = new DefaultSpellExecutor();
            attackHandler = new DefaultAttackHandler();
        }

        public GamePhase GetCurrentPhase()
        {
            return currentPhaseExecutor.Phase;
        }

        // Player creation happens here because different amounts of players will require a different IGamePhaseManager
        // Default GamePhaseManager will always only support two players
        //private void CreatePlayers()
        //{
        //    player1 = new Player(Element.Natural, "Player1-N-init");
        //    player2 = new Player(Element.Mechanical, "Player2-M-init");
        //    DecideTurnOrder();
        //}

        public void SetPlayers(Player p1, Player p2)
        {
            player1 = p1;
            player2 = p2;
            DecideTurnOrder();
            // ConfigureGameBoard();
        }

        private void DecideTurnOrder()
        {
            // TODO roll dice, check for Hasty Tomes, etc
            CurrentPlayer = player1;
            InactivePlayer = player2;
        }

        private void ConfigureGameBoard()
        {
            GameBoard = new GameBoardGui();
            GameBoard.AssignPlayersToLabels(player1, player2);
            GameBoard.UpdateCurrentPlayer(CurrentPlayer);
            GameBoard.Show();
        }

        public void StartGame()
        {
            if (player1 is null || player2 is null)
                throw new Exception("Players must be added to GamePhaseManager before starting game.");
            ConfigureGameBoard();

            bool isGameOver = false;
            while(!isGameOver)
            {
                ExecuteCurrentPhase();
                UpdateGameBoard();
                TransitionToNextPhase();
                isGameOver = IsGameOver();
            }
            DeclareWinner();
            // TODO persist GameBoard GUI
        }

        private bool IsGameOver()
        {
            //TODO: check if player health is zero
            return CurrentTurn > 60;
        }

        private void DeclareWinner()
        {
            //TODO determine winning player
            //Console.WriteLine($"Player {CurrentPlayer.Name} wins!");
        }

        private void ExecuteCurrentPhase()
        {
            currentPhaseExecutor.ExecuteGamePhase(this);
        }

        private void UpdateGameBoard()
        {
            GameBoard.UpdatePlayerLabels(player1);
            GameBoard.UpdatePlayerLabels(player2);
        }

        private void TransitionToNextPhase()
        {
            currentPhaseExecutor = gamePhaseExecutorFactory.GetNextPhaseExecutor(GetCurrentPhase());
        }

        public void SwitchPlayer()
        {
            //Console.WriteLine("----switching active player----");
            CurrentTurn++;
            InactivePlayer = CurrentPlayer;
            if (CurrentPlayer == player1) CurrentPlayer = player2;
            else CurrentPlayer = player1;

            GameBoard.UpdateCurrentPlayer(CurrentPlayer);
            // TODO update current round on GameBoard
        }

        public void ExecuteSpell(Spell spell)
        {
            spellExecutor.ExecuteSpell(spell);
        }

        public void HandleAttack(ElementalStrength attack)
        {
            attackHandler.HandleAttack(attack, InactivePlayer);
        }
    }
}