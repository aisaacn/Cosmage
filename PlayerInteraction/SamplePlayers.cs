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
        };

        static SamplePlayers()
        {
            SetJsonDirectoryPath();
            Samples = new Dictionary<string, PlayerSerializable>();
            GetSamplePlayersFromJson();
        }

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

        public static Player GetPlayer(string name)
        {
            PlayerSerializable playerS = Samples[name];
            Player player = new Player(playerS.Element, playerS.Name);
            player.SetSatchel(new Satchel(playerS.Items));
            return player;
        }

        private static void SavePlayerToJson(PlayerSerializable player)
        {
            var json = JsonSerializer.Serialize(player, _options);
            File.WriteAllText(jsonDirectoryPath + player.Name + ".json", json);
        }

        private static void LoadPlayerFromJson(string fileName)
        {
            var json = File.ReadAllText(fileName);
            PlayerSerializable player = JsonSerializer.Deserialize<PlayerSerializable>(json, _options);
            Samples.Add(player.Name, player);
        }

        private static void GetSamplePlayersFromJson()
        {
            foreach (string fileName in Directory.GetFiles(jsonDirectoryPath, "*.json"))
            {
                LoadPlayerFromJson(fileName);
            }
        }

        private static void SetJsonDirectoryPath()
        {
            string dir = Environment.CurrentDirectory;
            jsonDirectoryPath = $"{Directory.GetParent(dir).Parent.Parent.FullName}\\SamplePlayers\\";
            Console.WriteLine($"json path: {jsonDirectoryPath}");
        }
    }
}
