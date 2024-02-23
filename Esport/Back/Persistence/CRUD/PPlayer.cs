using Esport.Back.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Telerik.Maui;

namespace Esport.Back.Persistence.CRUD
{
    public class PPlayer
    {
        public List<EPlayer> Players { get; set; } = new List<EPlayer>()
        {
            new EPlayer("jojo", "bobo", new ETeam(6,"SKT T1"))
        };
        public PPlayer()
        {
            LoadPlayersAsync().Wait();
        }
        public void AddPlayer(EPlayer player)
        {
            Players.Add(player);

            var t = SavePlayersAsync().Result;
        }
        public void ModifyPlayer(int id, string name, string username, ETeam team)
        {
            foreach (var item in Players)
            {
                if (item.ID == id)
                {
                    item.Name = name;
                    item.Nickname = username;
                    item.Team = team;
                }
            }
            var t = SavePlayersAsync().Result;
        }
        public void RemovePlayer(int id)
        {
            foreach (var item in Players)
            {
                if (item.ID == id)
                {
                    Players.Remove(item);
                }
            }
        }

        public List<EPlayer> GetAllPlayer()
        {
            return Players;
        }

        private string filePath = "players.json";

        //Database
        public async Task LoadPlayersAsync()
        {
            Players = await ObjectSerializer.DeserializeFromFile<List<EPlayer>>(filePath) ?? new List<EPlayer>();
        }
        public async Task<bool> SavePlayersAsync()
        {
            await ObjectSerializer.SerializeToFile(Players, filePath);
            return true;
        }
    }
}
