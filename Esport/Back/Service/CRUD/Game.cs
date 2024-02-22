using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esport.Back.Service.CRUD.DataTransferObject;
using Esport.Interface;
namespace Esport.Back.Service.CRUD
{
    internal class Game
{
    public List<ITitleGame> ListOfGamesTitles = new List<ITitleGame> { 
        new TitleGame("League Of Legends"), 
        new TitleGame("Overwatch"),
        new TitleGame("JeuDuScam = Diablo 4") };

    public List<ITitleGame> GetAllGamesTitles()
        {
            return ListOfGamesTitles;
        }
    }
}
