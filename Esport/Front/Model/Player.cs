using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Front.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Team { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public Statistic Stats { get; set; }

        public Player(string name,string username,string team)
        {
            Name= name;
            Username= username;
            Team = team;
            Stats = new Statistic();
        }

        public void AddPlayer(Player player) 
        { 
            Players.Add(player);
        }
    }
}
