using Esport.Back.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esport.Back.Persistence;
using Esport.Back.Service.Games;
namespace Esport.Back.Persistence.CRUD
{
    internal class PGames
    {

        private EGame _gameToSave { get; set; }
        private string filePath = "players.json";

        //List de parties qui sera sauvegardé
        public List<EGame> ListOfGames { get; set; } = new List<EGame>()
        {
            new EGame(1,2,new List<int>(){1,2,3,4,5,6,7, }, new List<int>(){1,2}, 2, DateTime.Now),
            new EGame(2,1,new List<int>(){1,2,3,4,5,6,7, }, new List<int>(){2,3}, 3, DateTime.Now)
        };

        //Fonction qui appelle la fonction saveGameAsync et joue le rôle de l'async
        public void AddGame(EGame game)
        {
            ListOfGames.Add(game);

            var t = SaveGameAsync().Result;
        }

        //Fonction qui modifie la partie visé par l'ID
        public void ModifyGame(int id, int idVideoGame, List<int> PlayersId, List<int> TeamsId, int winnerTeamId, DateTime TimeStampDeLaPartie)
        {
            foreach (var item in ListOfGames)
            {
                if (item.Id == id)
                {
                    item.IdVideoGame = idVideoGame;
                    item.PlayersId = PlayersId;
                    item.TeamsId = TeamsId;
                    item.WinnerTeamId = winnerTeamId;
                    item.Date = TimeStampDeLaPartie;
                }
            }
            var t = SaveGameAsync().Result;
        }

        //Fonction qui fournis la liste des parties de manière asynchrone
        public async Task LoadPlayersAsync()
        {
            ListOfGames = await ObjectSerializer.DeserializeFromFile<List<EGame>>(filePath) ?? new List<EGame>();
        }

        /*Fonction Qui sauvegarde en asyncrone la sauvegarde et renvoie un bouléen pour que le reste de la stack s'execute une fois
        la sauvegarde terminé */
        public async Task<bool> SaveGameAsync()
        {
            await ObjectSerializer.SerializeToFile(_gameToSave, filePath);
            return true;
        }
        /*Suppression de la partie grace à son ID*/
        public void RemoveGame(int id)
        {
            foreach (var item in ListOfGames)
            {
                if (item.Id == id)
                {
                    ListOfGames.Remove(item);
                }
            }
        }
    }


}
