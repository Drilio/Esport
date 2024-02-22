using Esport.Front.Model;
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
        public List<Player> Players { get; set; } = new List<Player>()
        {
            new Player("jojo", "bobo", new Team("SKT T1"))
        };
        
        public void AddPlayer(Player player)
        {
            Players.Add(player);

            var t = SavePlayersAsync().Result;
        }
        public void ModifyPlayer(int id, string name, string username, Team team)
        {
            foreach (var item in Players)
            {
                if (item.Id == id)
                {
                    item.Name = name;
                    item.Username = username;
                    item.Team = team;
                }
            }
            var t = SavePlayersAsync().Result;
        }
        public void RemovePlayer(int id)
        {
            foreach (var item in Players)
            {
                if (item.Id == id)
                {
                    Players.Remove(item);
                }
            }
        }

        public List<Player> GetAllPlayer()
        {
            return Players;
        }

        private string filePath = "players.json";

        //Database
        public async Task LoadPlayersAsync()
        {
            Players = await ObjectSerializer.DeserializeFromFile<List<Player>>(filePath) ?? new List<Player>();
        }
        public async Task<bool> SavePlayersAsync()
        {
            await ObjectSerializer.SerializeToFile(Players, filePath);
            return true;
        }
    }
}
