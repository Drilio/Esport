using Esport.Back.Persistence.CRUD.DataTransferObject;
using Esport.Front.ViewModel;
using Esport.Interface;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Esport.Front.Model
{
    public class MPlayer : IPlayers, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Id { get; set; }
        public int TeamId { get; set; }
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

        //GUI permet de generer un id unique
        public MPlayer(string name, string username, MTeam team)
        {
            Guid id = Guid.NewGuid();
            this.Id = Math.Abs(id.GetHashCode());
            this.Name= name;
            this.Username= username;
            this.Team = new DTOTeam(team);
        }
        public MPlayer(IPlayers players)
        {
            Id = players.Id;
            TeamId = players.TeamId;
            Name = players.Name;
            Username = players.Username;
        }

        public MPlayer(string name,string username, int teamId)
        {
            Guid id = Guid.NewGuid();
            this.Id = Math.Abs(id.GetHashCode());
            this.Name= name;
            this.Username= username;
            this.TeamId= teamId;
        }
        
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
