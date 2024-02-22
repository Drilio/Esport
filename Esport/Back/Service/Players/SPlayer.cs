using Esport.Back.Persistence.CRUD;
using Esport.Front.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Maui;

namespace Esport.Back.Service.Players
{
    public class SPlayer
    {
        public PPlayer Players { get; set; } = new PPlayer();

        public void AddPlayer(string name, string username, Team team)
        {
            Player newPlayer = new Player(name, username, team);
            Players.AddPlayer(newPlayer);
        }

        public void ModifyPlayer(int id, string name, string username, Team team)
        {
            Players.ModifyPlayer(id, name, username, team);
        }

        public void DeletePlayer(int id)
        {
            Players.RemovePlayer(id);
        }

        public List<Player> GetPlayer()
        {
            return Players.GetAllPlayer();
        }
    }
}
