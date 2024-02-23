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
    internal class PVideoGame
    {
        //List de Jeux Video Hard codé
        //TODO:Proper CRUD de VideoGame
        public List<EVideoGame> ListOfVideoGames = new List<EVideoGame> {
        new EVideoGame(1,"jeu de fou","League of legend", "MOBA"),
        new EVideoGame(2, "jeu de con","Overwatch", "FPS"),
        new EVideoGame(3, "Jeu de Scam" ,"Diablo 4", "hack'n'slash") 
        };

        //Retourne les VideoGames Disponible
        public List<EVideoGame> GetAllVideoGames()
        {
            return ListOfVideoGames;
        }
    }
}
