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
        private IPassiveHandler passiveHandler;

        Player player1;
        Player player2;
        Player winner;
        public Player CurrentPlayer { get; private set; }
        public Player InactivePlayer { get; private set; }
        public int CurrentTurn { get; private set; }
        public GameBoardGui GameBoard { get; set; }

        private GamePhaseManager()
        {
            SetupGamePhaseManager();
        }

        private void SetupGamePhaseManager()
        {
            //CreatePlayers();
            //ConfigureGameBoard();

            gamePhaseExecutorFactory = new DefaultGamePhaseExecutorFactory();
            spellExecutor = new DefaultSpellExecutor();
            attackHandler = new DefaultAttackHandler();
            passiveHandler = new DefaultPassiveHandler();
        }

        public GamePhase GetCurrentPhase()
        {
            return currentPhaseExecutor.Phase;
        }

        public void SetPlayers(Player p1, Player p2)
        {
            player1 = p1;
            player2 = p2;
        }

        private void DecideTurnOrder()
        {
            // TODO polish
            if (player1.Haste > player2.Haste)
            {
                CurrentPlayer = player1;
                InactivePlayer = player2;
            }
            else if (player1.Haste < player2.Haste)
            {
                CurrentPlayer = player2;
                InactivePlayer = player1;
            }
            else
            {
                Random rand = new Random();
                int num = rand.Next(2);
                if (num == 0)
                {
                    CurrentPlayer = player1;
                    InactivePlayer = player2;
                }
                else
                {
                    CurrentPlayer = player2;
                    InactivePlayer = player1;
                }
            }
        }

        private void ConfigureGameBoard()
        {
            GameBoard.Invoke((MethodInvoker)delegate
            {
                GameBoard.AssignPlayersToLabels(player1, player2);
                GameBoard.UpdateCurrentPlayer(CurrentPlayer);
            });
        }

        public void StartGame()
        {
            if (player1 is null || player2 is null)
                throw new Exception("Players must be added to GamePhaseManager before starting game.");

            CurrentTurn = 0;
            winner = null;
            currentPhaseExecutor = gamePhaseExecutorFactory.CreateInitialPhaseExecutor();

            passiveHandler.HandlePassives(player1, player2);
            DecideTurnOrder();
            ConfigureGameBoard();

            while(!IsGameOver())
            {
                ExecuteCurrentPhase();
                UpdateGameBoard();
                TransitionToNextPhase();
            }
            DeclareWinner();
            // TODO persist GameBoard GUI
        }

        private bool IsGameOver()
        {
            //TODO: check if player health is zero and set this.winner
            if (InactivePlayer.Health <= 0)
            {
                winner = CurrentPlayer;
                return true;
            }

            // this block might be unnecessary, I dont think CurrentPlayer can take damage on their turn
            if (CurrentPlayer.Health <= 0)
            {
                winner = InactivePlayer;
                return true;
            }

            return false;
        }

        private void DeclareWinner()
        {
            GameBoard.Invoke((MethodInvoker)delegate
            {
                GameBoard.ShowWinner(winner);
            });
            //TODO determine winning player
            //Console.WriteLine($"Player {CurrentPlayer.Name} wins!");
        }

        private void ExecuteCurrentPhase()
        {
            currentPhaseExecutor.ExecuteGamePhase(this);
        }

        public void UpdateGameBoard()
        {
            GameBoard.Invoke((MethodInvoker)delegate
            {
                GameBoard.UpdatePlayerLabels(player1);
                GameBoard.UpdatePlayerLabels(player2);
            });
        }

        private void TransitionToNextPhase()
        {
            currentPhaseExecutor = gamePhaseExecutorFactory.GetNextPhaseExecutor(GetCurrentPhase());
        }

        public void SwitchPlayer()
        {
            //Console.WriteLine("----switching active player----");
            CurrentTurn++;
            Player tempCurrent = CurrentPlayer;
            CurrentPlayer = InactivePlayer;
            InactivePlayer = tempCurrent;

            GameBoard.Invoke((MethodInvoker)delegate
            {
                GameBoard.UpdateCurrentPlayer(CurrentPlayer);
                // TODO update current round on GameBoard
            });
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