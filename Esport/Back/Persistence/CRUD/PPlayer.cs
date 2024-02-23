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
        // Collection de joueurs
        public List<EPlayer> Players { get; set; } = new List<EPlayer>() { };
        public PPlayer()
        {
            // Charge les joueurs à partir de la source de données lors de la création de l'instance
            LoadPlayersAsync().Wait();
        }

        // Ajoute un joueur à la collection
        public void AddPlayer(EPlayer player)
        {
            Players.Add(player);
            // Sauvegarde les joueurs dans la source de données
            var t = SavePlayersAsync().Result;
        }
        // Modifie un joueur dans la collection
        public void ModifyPlayer(int id, string name, string username, ETeam team)
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
            // Sauvegarde les joueurs modifiés dans la source de données
            var t = SavePlayersAsync().Result;
        }

        // Supprime un joueur de la collection
        public void RemovePlayer(int id)
        {
            foreach (var item in Players)
            {
                if (item.Id == id)
                {
                    Players.Remove(item);
                    break;
                }
            }
        }

        // Récupère tous les joueurs de la collection
        public List<EPlayer> GetAllPlayer()
        {
            return Players;
        }

        private string filePath = "players.json";

        //Database
        // Charge les joueurs à partir de la source de données asynchrone
        public async Task LoadPlayersAsync()
        {
            Players = await ObjectSerializer.DeserializeFromFile<List<EPlayer>>(filePath) ?? new List<EPlayer>();
        }

        // Sauvegarde les joueurs dans la source de données asynchrone
        public async Task<bool> SavePlayersAsync()
        {
            await ObjectSerializer.SerializeToFile(Players, filePath);
            return true;
        }
    }
}
