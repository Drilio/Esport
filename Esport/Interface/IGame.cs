using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Interface
{
    public interface IGame
    {
        public int Id { get; set; }
        public int IdVideoGame { get; set; }
        public List<int> PlayersId { get; set; }

        public List<int> TeamsId { get; set; }

        public int WinnerTeamId { get; set; }

        public DateTime Date { get; set; }
    }
}
