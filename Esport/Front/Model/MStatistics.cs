using Esport.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Esport.Front.Model
{
    public class MTitleVideoGame: INotifyPropertyChanged, ITitleVideoGame
    {

        private string _title;

        public MTitleVideoGame (ITitleVideoGame myTitle)
        {
            this._title = myTitle.Title;
        }
        public string Title
        {
            get { return _title; }
            set { _title = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public MTitleVideoGame()
        {

        }
    public void OnPropertyChanged([CallerMemberName] string name = "") =>
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
