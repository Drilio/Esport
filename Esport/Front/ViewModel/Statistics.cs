using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Front.ViewModel
{
    public class Statistics
    {
        public List<string> PickerGame { get; set; } = new List<string> {"League Of Legends", "Overwatch", "JeuDuScam = Diablo 4"};
        public List<string> PickerWinLoose { get; set; } = new List<string> { "Win", "GROS LOOSER TU PUES" };

        internal void LoadData()
        {

        }
        Statistics() {
            LoadData();
        }

    }
}
