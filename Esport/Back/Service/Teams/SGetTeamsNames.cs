using Esport.Back.Persistence.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Service.Teams
{
    public class SGetTeamsNames
    {
        PTeams _pTeams = new PTeams();

        public List<string> GetTeamsName()
        {
            return _pTeams.GetAllTeams()
                .Select(T => T.Name)
                .ToList();
        }
    }
}
