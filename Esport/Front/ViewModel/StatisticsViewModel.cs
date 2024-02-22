using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Esport.Back.Service.Games;
using Esport.Front.Model;

namespace Esport.Front.ViewModel
{
    public class StatisticsViewModel
    {
        public ICommand CreateGame {  get; set; }
        public List<MTitleVideoGame> PickerVideoGame { get; set; }
        public List<string> PickerWinLoose { get; set; } = new List<string> { "Win", "GROS LOOSER TU PUES" };

        private SGetVideoGame _getVideoGame = new SGetVideoGame();

        public void AddGame()
        {

        }
        internal void LoadData()
        {
            var toto = _getVideoGame.GetAllTitleVideoGame();
            this.PickerVideoGame = _getVideoGame.GetAllTitleVideoGame().Select(T => new MTitleVideoGame(T)).ToList();
        }
        public StatisticsViewModel() {
            LoadData();
            CreateGame = new Command(AddGame);
        }
    }
}
