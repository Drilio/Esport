using Esport.Back.Persistence.CRUD.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esport.Back.Persistence.CRUD;
using Esport.Interface;

namespace Esport.Back.Service.Games
{
    public class SGetGame
    {
        //Initialisation de la list De Titre de jeux qui va être servis à l'appelle de la fonction GetAllGame
        public List<ITitleGame> TitleGameList { get; set; } = new List<ITitleGame>();

        //Implementation de la classe Game depuis le CRUD persistence
        private PGame _pgame= new PGame();

        //Cette fonction retourne la liste de tous les titres de jeux présents dans la BDD
        public List<ITitleGame> GetAllTitleGame()
        {
            //Iteration sur la collection de TitleGmae pour les ajouter à la liste
            return _pgame.GetAllGames().Select(G => new TitleGame(G.Title) as ITitleGame).ToList();  
        }
    }
}
