using CosmageV2.PlayerInteraction.Itemization;
using CosmageV2.PlayerInteraction.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CosmageV2.PlayerInteraction
{
    public static class SamplePlayers
    {
        public static Dictionary<string, PlayerSerializable> Samples { get; private set; }

        private static string jsonDirectoryPath;
        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new ItemFlyweightJsonConverter() }
        };

        static SamplePlayers()
        {
            SetJsonDirectoryPath();
            Samples = new Dictionary<string, PlayerSerializable>();
            GetSamplePlayersFromJson();
        }

        /// <summary>
        /// Stores provided Player.
        /// </summary>
        public static void AddCustomSamplePlayer(Player player)
        {
            PlayerSerializable newPlayer = new PlayerSerializable(player);
            if (Samples.ContainsKey(newPlayer.Name))
            {
                Samples[newPlayer.Name] = newPlayer;
            }
            else
            {
                Samples.Add(newPlayer.Name, newPlayer);
            }
            SavePlayerToJson(newPlayer);
        }

        /// <summary>
        /// Returns Player by provided name.
        /// </summary>
        public static Player GetPlayer(string name)
        {
            PlayerSerializable playerS = Samples[name];
            Player player = new Player(playerS.Element, playerS.Name);
            player.SetSatchel(new Satchel(playerS.Items));
            return player;
        }

        /// <summary>
        /// Serializes provided Player to Json.
        /// </summary>
        private static void SavePlayerToJson(PlayerSerializable player)
        {
            var json = JsonSerializer.Serialize(player, _options);
            File.WriteAllText(jsonDirectoryPath + player.Name + ".json", json);
        }

        /// <summary>
        /// Deserializes Json file to Player object. Populates SamplePlayers.
        /// </summary>
        private static void LoadPlayerFromJson(string fileName)
        {
            var json = File.ReadAllText(fileName);
            PlayerSerializable player = JsonSerializer.Deserialize<PlayerSerializable>(json, _options);
            Samples.Add(player.Name, player);
        }

        /// <summary>
        /// Fetches all Json objects in SamplePlayer directory.
        /// </summary>
        private static void GetSamplePlayersFromJson()
        {
            foreach (string fileName in Directory.GetFiles(jsonDirectoryPath, "*.json"))
            {
                LoadPlayerFromJson(fileName);
            }
        }

        /// <summary>
        /// Finds path to SamplePlayers directory based on working directory.
        /// </summary>
        private static void SetJsonDirectoryPath()
        {
            string dir = Environment.CurrentDirectory;
            jsonDirectoryPath = $"{Directory.GetParent(dir).Parent.Parent.FullName}\\SamplePlayers\\";
            Console.WriteLine($"json path: {jsonDirectoryPath}");
        }
    }
}
