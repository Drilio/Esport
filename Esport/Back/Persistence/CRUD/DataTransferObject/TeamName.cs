using Esport.Interface;

namespace Esport.Back.Persistence.CRUD.DataTransferObject
{
    public class TeamName :ITeam
    {
        public string Name { get; set; }
        public TeamName(string name) 
        { 
            this.Name = name; 
        }
    }
}
