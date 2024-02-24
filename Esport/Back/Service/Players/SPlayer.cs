using Esport.Back.Persistence.CRUD;
using Esport.Back.Domain;
using Esport.Interface;
using Esport.Back.Persistence.CRUD.DataTransferObject;
using Esport.Front.Model;

namespace Esport.Back.Service.Players
{
    public class SPlayer
    {
        public PPlayer Players { get; set; } = new PPlayer();
        //ajoute un nouveau joueur a PLayers
        public void AddPlayer(int id, string name, string username, ITeam team)
        {
            EPlayer newPlayer = new EPlayer(name, username, new ETeam(team.Id, team.Name));
            Players.AddPlayer(newPlayer);
        }
        //modifie les détails du joueur correspondant à cet ID
        public void ModifyPlayer(int id, string name, string username, ITeam team)
        {
            Players.ModifyPlayer(id, name, username, new ETeam(team.Id,team.Name));
        }
        //supprime le joueur correspondant à l'ID
        public void DeletePlayer(int id)
        {
            Players.RemovePlayer(id);
        }
        //renvoie tous les joueurs à partir de la classe PPlayer
        public List<IPlayers> GetPlayer()
        {
            return Players.GetAllPlayer().Select(P => new DTOPlayer(P.Id,P.Name, P.Username, P.Team.Id) as IPlayers).ToList();
        }
        //renvoie un joueur spécifique en fonction de son ID 
        public List<IPlayers> GetPlayerById(int id)
        {
            return Players.GetAllPlayer().Where(t=>t.Id==id).Select(P => new DTOPlayer(P.Id,P.Name, P.Username, P.Team.Id) as IPlayers).ToList();
        }
    }
}
