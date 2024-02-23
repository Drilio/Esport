using Esport.Front.Model;
using Esport.Interface;

namespace Esport.Back.Persistence.CRUD.DataTransferObject
{
    public class TeamName :ITeam
    {
        public int id { get; set; }
        public string Name { get; set; }
        public TeamName( int id ,string name) 
        { 
            this.id = id;
            this.Name = name; 
        }
        public TeamName(ITeam team )
        {
            this.Name = team.Name;
            this.id = team.id;
        }

        public TeamName( MTeam team) {
            this.Name = team.Name;
            this.id = team.id;
                }
    }
}
