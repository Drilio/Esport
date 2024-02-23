using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Domain
{
    public class EPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public ETeam Team{ get; set; }
        public List<StatByEntities> Statistics { get; set; }
        public EPlayer(string name, string nickname, ETeam team)
        {
            Guid id = Guid.NewGuid();
            this.Id = Math.Abs(id.GetHashCode());
            Name = name;
            Username = nickname;
            Team = team;
        }
        public List<EGame>  Parties { get; set; }
    }
}
