using Esport.Interface;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Esport.Front.Model
{
    public class Player : IPlayers, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Id { get; set; }
        public Team Team { get; set; }
        public Statistic Stats { get; set; }
        public string _userName;
        public string Username
        {
            get => _userName;
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged();
                }
            }
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
        public Player(string name, string username, Team team)
        {
            DateTime date=new DateTime();
            this.Id=(int)date.Millisecond;
            this.Name= Name;
            this.Username= Username;
            this.Team = Team;
            this.Stats = new Statistic();
        }
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
