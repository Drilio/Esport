using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Domain
{
    public class EGame
    {
        public int Id { get; set; }
        public int IdVideoGame { get; set; }

        public List<int> PlayersId { get; set; }

        public List<int> TeamsId { get; set; }

        public int WinnerTeamId { get; set; }

        public DateTime Date { get; set; }
        //Constructeur
        public EGame(int id, int IdVideoGame, List<int> PlayersId, List<int>TeamsId, int WinnerTeamId, DateTime Date) { 
            this.Id = id;
            this.IdVideoGame = IdVideoGame;
            this.PlayersId = PlayersId;
            this.TeamsId = TeamsId;
            this.WinnerTeamId = WinnerTeamId;
            this.Date = Date;
        }

    }
}
