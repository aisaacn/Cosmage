﻿using CosmageV2.PlayerInteraction.Itemization;
using System.Collections.Generic;

namespace CosmageV2.PlayerInteraction
{
    public static class SamplePlayers
    {
        public static Dictionary<string, Player> Samples { get; private set; }

        static SamplePlayers()
        {
            // TODO persist sample players between sessions
            Samples = new Dictionary<string, Player>();
            AddSampleNaturalPlayer();
            AddSampleMechanicalPlayer();
            AddSampleUnnaturalPlayer();
        }

        public static void AddCustomSamplePlayer(Player player)
        {
            if (Samples.ContainsKey(player.Name))
            {
                Samples[player.Name] = player;
            }
            else
            {
                Samples.Add(player.Name, player);
            }
        }

        private static void AddSampleNaturalPlayer()
        {
            List<Item> items = new List<Item>()
            {
                ItemRegistry.Catalysts.Attack, ItemRegistry.Catalysts.Ward, ItemRegistry.Catalysts.Construct,
                ItemRegistry.Essences.BasicNatural, ItemRegistry.Essences.AdvancedNatural,
                ItemRegistry.Essences.BasicMechanical, ItemRegistry.Essences.AdvancedMechanical, ItemRegistry.Essences.AdvancedMechanical,
                ItemRegistry.Essences.BasicUnnatural, ItemRegistry.Essences.AdvancedUnnatural, ItemRegistry.Essences.AdvancedUnnatural
            };
            Player player = new Player(Element.Natural, "Natural Sample Player");
            player.SetSatchel(new Satchel(items));

            Samples.Add(player.Name, player);
        }

        private static void AddSampleMechanicalPlayer()
        {
            List<Item> items = new List<Item>()
            {
                ItemRegistry.Catalysts.Attack, ItemRegistry.Catalysts.Ward, ItemRegistry.Catalysts.Construct,
                ItemRegistry.Essences.BasicNatural, ItemRegistry.Essences.AdvancedNatural, ItemRegistry.Essences.AdvancedMechanical,
                ItemRegistry.Essences.BasicMechanical, ItemRegistry.Essences.AdvancedMechanical,
                ItemRegistry.Essences.BasicUnnatural, ItemRegistry.Essences.AdvancedUnnatural, ItemRegistry.Essences.AdvancedUnnatural
            };
            Player player = new Player(Element.Mechanical, "Mechanical Sample Player");
            player.SetSatchel(new Satchel(items));

            Samples.Add(player.Name, player);
        }

        private static void AddSampleUnnaturalPlayer()
        {
            List<Item> items = new List<Item>()
            {
                ItemRegistry.Catalysts.Attack, ItemRegistry.Catalysts.Ward, ItemRegistry.Catalysts.Construct,
                ItemRegistry.Essences.BasicNatural, ItemRegistry.Essences.AdvancedNatural, ItemRegistry.Essences.AdvancedNatural,
                ItemRegistry.Essences.BasicMechanical, ItemRegistry.Essences.AdvancedMechanical, ItemRegistry.Essences.AdvancedMechanical,
                ItemRegistry.Essences.BasicUnnatural, ItemRegistry.Essences.AdvancedUnnatural
            };
            Player player = new Player(Element.Unnatural, "Unnatural Sample Player");
            player.SetSatchel(new Satchel(items));

            Samples.Add(player.Name, player);
        }
    }
}
