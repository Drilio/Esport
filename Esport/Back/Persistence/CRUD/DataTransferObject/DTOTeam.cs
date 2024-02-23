using Esport.Front.Model;
using Esport.Interface;

namespace Esport.Back.Persistence.CRUD.DataTransferObject
{
    public class DTOTeam :ITeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DTOTeam( int id ,string name) 
        { 
            this.Id = id;
            this.Name = name; 
        }
        public DTOTeam(ITeam team )
        {
            this.Name = team.Name;
            this.Id = team.Id;
        }

        public DTOTeam( MTeam team) {
            this.Name = team.Name;
            this.Id = team.Id;
                }
    }
}
