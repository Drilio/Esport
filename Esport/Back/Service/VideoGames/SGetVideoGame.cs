using Esport.Back.Persistence.CRUD.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esport.Back.Persistence.CRUD;
using Esport.Interface;

namespace Esport.Back.Service.VideoGames
{
    public class SGetVideoGame
    {

        //Implementation de la classe Game depuis le CRUD persistence
        private PVideoGame _pVideoGame = new PVideoGame();

        //Cette fonction retourne la liste de tous les titres de jeux présents dans la BDD
        public List<ITitleVideoGame> GetAllTitleVideoGame()
        {
            //Iteration sur la collection de TitleGmae pour les ajouter à la liste
            return _pVideoGame.GetAllVideoGames().Select(VG => new TitleVideoGame(VG.Title) as ITitleVideoGame).ToList();
        }
    }
}
