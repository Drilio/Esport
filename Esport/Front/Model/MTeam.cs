using Esport.Interface;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Esport.Front.Model
{
    public class MTeam : ITeam, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

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
        public MTeam(ITeam team)
        {
            this._name = team.Name;
        }
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

