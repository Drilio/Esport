using Esport.Back.Persistence.CRUD.DataTransferObject;
using Esport.Front.Model;

namespace Esport.Interface
{
    public interface IPlayers
    {
        int Id { get; set; }
        string Name { get; set; }
        string Username { get; set; }
        DTOTeam Team { get; set; }
    }

    public interface ISelectedPlayer : IPlayers
    {
        bool IsSelected { get; set; }
    }

    public interface ITeam
    {
        string Name { get; set; }
        int id { get; set; }
    }

}
