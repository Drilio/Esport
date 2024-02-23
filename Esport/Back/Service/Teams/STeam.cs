using Esport.Back.Persistence.CRUD;
using Esport.Back.Persistence.CRUD.DataTransferObject;
using Esport.Interface;

namespace Esport.Back.Service.Teams
{
    public class STeam
    {
        public List<ITeam> Teams { get; set; } = new List<ITeam>();

        private PTeam _team = new PTeam();

        public List<ITeam> GetTeamsById(int id)
        {
            return _team.GetAllTeams().Where(t => t.Id == id).Select(T => new DTOTeam(T.Id, T.Name) as ITeam).ToList();
        }
        public List<ITeam> GetTeams()
        {
            return _team.GetAllTeams().Select(T => new DTOTeam(T.Id, T.Name) as ITeam).ToList();
        }
    }
}
