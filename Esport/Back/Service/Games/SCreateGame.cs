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
    internal class SCreateGame
    {
        //implémentation de l'interface
        private PGames _persitenceGame = new PGames();

        /*Prend une instensiation de l'interface Game et la renvoie à la couche de persistence
        une fois transformer en EGame afin de créer une nouvelle partie de jeu*/
        public void SaveGame( IGame gameToSave)
        {
            EGame newGame = new EGame(gameToSave);
            _persitenceGame.AddGame(newGame);
        }
    }
}
