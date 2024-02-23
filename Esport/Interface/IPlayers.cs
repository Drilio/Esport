using Esport.Back.Persistence.CRUD.DataTransferObject;
using Esport.Front.Model;

namespace Esport.Interface
{
    public interface IPlayers
    {
        int Id { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        int TeamId { get; set; }
    }

    public interface ITeam
    {
        string Name { get; set; }
        int Id { get; set; }
    }

}
