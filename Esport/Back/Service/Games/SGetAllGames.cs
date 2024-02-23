using Esport.Back.Domain;
using Esport.Back.Persistence.CRUD;
using Esport.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Back.Service.Games
{
    internal class SGetAllGames
    {
        private PGames _pGames = new PGames();

        public List<IGame> GetAllGames()
        {
            return _pGames.LoadGamesAsync()
                .Result
                .Select(G => G as IGame)
                .ToList();
        }
    }
}
