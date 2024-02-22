using Esport.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Front.Model
{
    public class Player : ISelectedPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public Team Team { get; set; }
        public Statistic Stats { get; set; }

        public Player(string name,string username,Team team)
        {
            DateTime date=new DateTime();
            Id=(int)date.Millisecond;
            Name= name;
            Username= username;
            Team = team;
            Stats = new Statistic();
        }
    }
}
