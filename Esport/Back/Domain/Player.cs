using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Domain
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public ETeam Team{ get; set; }
        public List<StatByEntities> Statistics { get; set; }
        public List<EGame>  Parties { get; set; }
    }
}
