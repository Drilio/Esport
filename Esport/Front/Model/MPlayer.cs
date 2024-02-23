using Esport.Back.Persistence.CRUD.DataTransferObject;
using Esport.Interface;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Esport.Front.Model
{
    public class MPlayer : IPlayers, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Id { get; set; }
        public DTOTeam Team { get; set; }
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
        public MPlayer(string name, string username, MTeam team)
        {
            DateTime date=new DateTime();
            this.Id=(int)date.Millisecond;
            this.Name= name;
            this.Username= username;
            this.Team = new DTOTeam(team);
        }
        public MPlayer(IPlayers players)
        {
            Id = players.Id;
            Team = players.Team;
            Name = players.Name;
            Username = players.Username;
        }
        
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
