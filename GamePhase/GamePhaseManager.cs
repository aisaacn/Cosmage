﻿using CosmageV2.PlayerInteraction;
using CosmageV2.GUI;
using System;
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

        public IGuiManager GuiManager { get; private set; }
        public IRulesetManager RulesetManager { get; private set; }

        private IGamePhaseExecutor currentPhaseExecutor;
        private IGamePhaseExecutorFactory gamePhaseExecutorFactory;
        private ISpellExecutor spellExecutor;
        private IAttackHandler attackHandler;
        private IPassiveHandler passiveHandler;
        private IGameBoardCommunicator gameBoardCommunicator; // TODO consider merging with IGuiManager
        private IGameValidator gameValidator;

        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }
        public Player CurrentPlayer { get; private set; }
        public Player InactivePlayer { get; private set; }
        public int CurrentTurn { get; private set; }

        public void ConfigureRuleset(IRulesetManager ruleset)
        {
            RulesetManager = ruleset;
            gamePhaseExecutorFactory = RulesetManager.GamePhaseExecutorFactory;
            spellExecutor = RulesetManager.SpellExecutor;
            attackHandler = RulesetManager.AttackHandler;
            passiveHandler = RulesetManager.PassiveHandler;
            gameValidator = RulesetManager.GameValidator;
        }

        public void ConfigureGui(IGuiManager guiManager)
        {
            GuiManager = guiManager;
            gameBoardCommunicator = GuiManager.GameBoardCommunicator;
        }

        public GamePhase GetCurrentPhase()
        {
            return currentPhaseExecutor.Phase;
        }

        public void SetPlayers(Player p1, Player p2)
        {
            Player1 = p1;
            Player2 = p2;
        }

        private void DecideTurnOrder()
        {
            // TODO polish
            if (Player1.Haste > Player2.Haste)
            {
                CurrentPlayer = Player1;
                InactivePlayer = Player2;
            }
            else if (Player1.Haste < Player2.Haste)
            {
                CurrentPlayer = Player2;
                InactivePlayer = Player1;
            }
            else
            {
                Random rand = new Random();
                int num = rand.Next(2);
                if (num == 0)
                {
                    CurrentPlayer = Player1;
                    InactivePlayer = Player2;
                }
                else
                {
                    CurrentPlayer = Player2;
                    InactivePlayer = Player1;
                }
            }
        }

        private void ConfigureGameBoard()
        {
            gameBoardCommunicator.ConfigurePlayers(Player1, Player2);
            gameBoardCommunicator.UpdateCurrentPlayer(CurrentPlayer);
        }

        public void StartGame()
        {
            gameValidator.ValidateGame(this);

            CurrentTurn = 0;
            currentPhaseExecutor = gamePhaseExecutorFactory.CreateInitialPhaseExecutor();

            passiveHandler.HandlePassives(Player1, Player2);
            DecideTurnOrder();
            ConfigureGameBoard();

            while(!IsGameOver())
            {
                ExecuteCurrentPhase();
                UpdateGameBoard();
                TransitionToNextPhase();
            }
        }

        private bool IsGameOver()
        {
            if (InactivePlayer.Health <= 0)
            {
                DeclareWinner(CurrentPlayer);
                return true;
            }

            // TODO this block might be unnecessary; I dont think CurrentPlayer can take damage on their turn
            if (CurrentPlayer.Health <= 0)
            {
                DeclareWinner(InactivePlayer);
                return true;
            }

            return false;
        }

        private void DeclareWinner(Player winner)
        {
            gameBoardCommunicator.DeclareWinner(winner);
        }

        private void ExecuteCurrentPhase()
        {
            currentPhaseExecutor.ExecuteGamePhase(this);
        }

        public void UpdateGameBoard()
        {
            gameBoardCommunicator.UpdatePlayerState(Player1, Player2);
        }

        private void TransitionToNextPhase()
        {
            currentPhaseExecutor = gamePhaseExecutorFactory.GetNextPhaseExecutor(GetCurrentPhase());
        }

        public void SwitchPlayer()
        {
            CurrentTurn++;
            Player tempCurrent = CurrentPlayer;
            CurrentPlayer = InactivePlayer;
            InactivePlayer = tempCurrent;

            gameBoardCommunicator.UpdateCurrentPlayer(CurrentPlayer);
            // TODO update current round on GameBoard
        }

        public void ExecuteSpell(Spell spell)
        {
            spellExecutor.ExecuteSpell(spell);
        }

        public void HandleAttack(ElementalStrength attack, Targetable target)
        {
            attackHandler.HandleAttack(attack, target);
            InactivePlayer.RemoveDetroyedConstructs();
        }

        public void HandlePlayerAttack(ElementalStrength attack)
        {
            HandleAttack(attack, CurrentPlayer.HandleChooseAttackTarget());
        }

        public void LogEvent(string log)
        {
            gameBoardCommunicator.LogEvent(log);
        }
    }
}