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
    public class MTitleGame: INotifyPropertyChanged, ITitleGame
    {

        private string _title;

        public MTitleGame (ITitleGame myTitle)
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
        public MTitleGame()
        {

        }
    public void OnPropertyChanged([CallerMemberName] string name = "") =>
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
