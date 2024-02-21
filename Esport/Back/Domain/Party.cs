using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Domain
{
    public class Party
    {
        public int Id { get; set; }
        public string Game { get; set; }

        public List<Player> Players { get; set; }

        public List<Team> Teams { get; set; }

        public Team Winner { get; set; }

        public DateTime Date { get; set; }

    }
}
