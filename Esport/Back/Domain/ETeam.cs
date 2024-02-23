using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Domain
{
    public class ETeam
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<int> PlayersId{ get; set; }

        public List<int> GameId { get; set; }
        //constructor
        public ETeam(int id, string name, List<int> PlayersId,List<int> GamesId) { 
        this.Id = id;
        this.Name = name;
        this.PlayersId = PlayersId;
        this.GameId = GamesId;
        }
    }
}
