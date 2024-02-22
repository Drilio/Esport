using Esport.Back.Domain;

namespace Esport.Back.Persistence.CRUD
{
    public class PTeam
    {
        public List<Team> Teams { get; set; } = new List<Team>()
        {
             new Team(1,"JU"),
             new Team(2,"Vitality"),
             new Team(3,"SKT T1")
        };

        public List<Team> GetAllTeams()
        {
            return Teams;
        }
    }
}
