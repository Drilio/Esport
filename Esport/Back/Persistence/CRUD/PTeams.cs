using Esport.Back.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Persistence.CRUD
{
    class PTeams
    {
            //List de team Hard codé
            //TODO:Proper CRUD de Team
            public List<ETeam> ListOfTeam = new List<ETeam> {
            new ETeam(1, "KC", new List<int>{1,2,3,4,5 }, new List<int>{1,2,3,4,5}),
            new ETeam(1, "Vitality", new List<int>{6,7,8,9,10}, new List<int>{1,2,3,4}),
            new ETeam(3, "Solary", new List<int>{11,12,13,14,15}, new List<int>{5})
        };

            //Retourne les Team Disponible
            public List<ETeam> GetAllTeams()
            {
                return ListOfTeam;
            }
        }
}
