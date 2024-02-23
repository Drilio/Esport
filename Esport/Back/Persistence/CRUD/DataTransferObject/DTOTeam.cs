using Esport.Front.Model;
using Esport.Interface;

namespace Esport.Back.Persistence.CRUD.DataTransferObject
{
    public class DTOTeam :ITeam
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DTOTeam( int id ,string name) 
        { 
            this.id = id;
            this.Name = name; 
        }
        public DTOTeam(ITeam team )
        {
            this.Name = team.Name;
            this.id = team.id;
        }

        public DTOTeam( MTeam team) {
            this.Name = team.Name;
            this.id = team.id;
                }
    }
}
