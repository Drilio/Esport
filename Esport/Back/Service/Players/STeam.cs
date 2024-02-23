using Esport.Back.Persistence.CRUD;
using Esport.Back.Persistence.CRUD.DataTransferObject;
using Esport.Interface;

namespace Esport.Back.Service.Players
{
    public class STeam
    {
        public List<ITeam> Teams { get; set; }=new List<ITeam>();

        private PTeam _team = new PTeam();

        public List<ITeam> GetTeams()
        {
            return _team.GetAllTeams().Select(T => new TeamName(T.Id,T.Name) as ITeam).ToList();
        }
    }
}
