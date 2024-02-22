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

        //public List<EGame> DummyGammes{ get; set; } = new List<EGame>()
        //{
        //    new ("jojo", "bobo", new Team(1, "JU"))
        //};
        private EGame _gameToSave { get; set; }

        public void AddGame(EGame game)
        {
            _gameToSave = game;

            var t = SaveGameAsync().Result;
        }
        public void CreateGame(EGame gameToSave)
        {
            var newGame = ObjectSerializer.SerializeToFile(gameToSave, "C:\\Users\\drilio\\source\\repos\\Esport\\Esport\\Back\\DataBase"); 
        }

        private string filePath = "players.json";

        public async Task<bool> SaveGameAsync()
        {
            await ObjectSerializer.SerializeToFile(_gameToSave, filePath);
            return true;
        }
    }
}
