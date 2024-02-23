using Esport.Back.Domain;

namespace Esport.Back.Persistence.CRUD
{
    public class PTeam
    {
        public List<ETeam> Teams { get; set; } = new List<ETeam>()
        {
             new ETeam(1,"JU"),
             new ETeam(2,"Vitality"),
             new ETeam(3,"SKT T1")
        };

        public List<ETeam> GetAllTeams()
        {
            return Teams;
        }
    }
}
