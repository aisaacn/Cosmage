﻿using CosmageV2.PlayerInteraction;
using CosmageV2.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmageV2.GamePhase
{
    internal class GamePhaseManager
    {
        // TODO: reconsider lazy instantiation (it's just so easy)
        private static readonly Lazy<GamePhaseManager> lazy =
            new Lazy<GamePhaseManager>(() => new GamePhaseManager());
        public static GamePhaseManager Instance { get { return lazy.Value; } }

        private IGamePhaseExecutor currentPhaseExecutor;
        private IGamePhaseExecutorFactory gamePhaseExecutorFactory;

        Player player1;
        Player player2;
        public Player CurrentPlayer { get; private set; }
        public int CurrentTurn { get; private set; }

        private GamePhaseManager()
        {
            SetupGamePhaseManager();
        }

        private void SetupGamePhaseManager()
        {
            CreatePlayers();
            CurrentPlayer = this.player1;
            CurrentTurn = 0;

            gamePhaseExecutorFactory = new DefaultGamePhaseExecutorFactory();
            currentPhaseExecutor = gamePhaseExecutorFactory.CreateInitialPhaseExecutor();
        }

        public GamePhase GetCurrentPhase()
        {
            return currentPhaseExecutor.Phase;
        }

        // Player creation happens here because different amounts of players will require a different IGamePhaseManager
        // Default GamePhaseManager will always only support two players
        private void CreatePlayers()
        {
            this.player1 = new Player(Element.Natural, "Player1-N");
            this.player2 = new Player(Element.Mechanical, "Player2-M");
        }

        public void StartGame()
        {
            if (player1 is null || player2 is null)
                throw new Exception("Players must be added to GamePhaseManager before starting game.");

            bool isGameOver = false;
            while(!isGameOver)
            {
                ExecuteCurrentPhase();
                TransitionToNextPhase();
                isGameOver = IsGameOver();
            }
            DeclareWinner();
        }

        private bool IsGameOver()
        {
            //TODO: check if player health is zero
            return CurrentTurn > 2;
        }

        private void DeclareWinner()
        {
            //TODO determine winning player
            Console.WriteLine($"Player {CurrentPlayer.Name} wins!");
        }

        private void ExecuteCurrentPhase()
        {
            currentPhaseExecutor.ExecuteGamePhase(this);
        }

        private void TransitionToNextPhase()
        {
            currentPhaseExecutor = gamePhaseExecutorFactory.GetNextPhaseExecutor(currentPhaseExecutor.Phase);
        }

        public void SwitchPlayer()
        {
            //TODO
            Console.WriteLine("----switching active player----");
            CurrentTurn++;
            if (CurrentPlayer == player1) CurrentPlayer = player2;
            else CurrentPlayer = player1;
        }
    }
}