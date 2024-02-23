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

        public List<EPlayer> Players { get; set; }

        public List<StatByEntities> Statistics { get; set; }

        public List<Party> Parties { get; set; }

        public List<Statistic> Results { get; set; }

        public ETeam(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
