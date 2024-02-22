using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esport.Back.Domain;
using Esport.Back.Persistence.CRUD.DataTransferObject;
using Esport.Interface;
namespace Esport.Back.Persistence.CRUD
{
    internal class PGame
    {
        public List<EGame> ListOfGames = new List<EGame> {
        new EGame(1,"jeu de fou","League of legend", "MOBA"),
        new EGame(2, "jeu de con","Overwatch", "FPS"),
        new EGame(3, "Jeu de Scam" ,"Diablo 4", "hack'n'slash") 
        };

        public List<EGame> GetAllGames()
        {
            return ListOfGames;
        }
    }
}
