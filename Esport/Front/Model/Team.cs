using Esport.Interface;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Esport.Front.Model
{
    public class Team : ITeam, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }
        public Team(string name)
        {
            this._name = name;
        }
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

