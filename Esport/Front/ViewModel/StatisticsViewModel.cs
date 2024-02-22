using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esport.Back.Service.Games;
using Esport.Front.Model;
using Esport.Interface;

namespace Esport.Front.ViewModel
{
    public class StatisticsViewModel
    {
        public List<MTitleGame> PickerGame { get; set; }
        public List<string> PickerWinLoose { get; set; } = new List<string> { "Win", "GROS LOOSER TU PUES" };

        private SGetGame _getGame = new SGetGame();
        internal void LoadData()
        {
            var toto = _getGame.GetAllTitleGame();
            this.PickerGame = _getGame.GetAllTitleGame().Select(T => new MTitleGame(T)).ToList();
        }
        public StatisticsViewModel() {
            LoadData();
        }
    }
}
