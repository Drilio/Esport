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

        public List<EPlayer> Players { get; set; }

        public List<ETeam> Teams { get; set; }

        public ETeam Winner { get; set; }

        public DateTime Date { get; set; }

    }
}
