using Esport.Back.Service.Players;
using Esport.Front.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Esport.Front.ViewModel
{
    public class PlayerViewModel:INotifyPropertyChanged
    {
        private readonly SPlayer servicePlayer;
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly STeam serviceTeam;

        private Player _selectedPlayer;
        public Player SelectedPlayer
        {
            get => _selectedPlayer;
            set
            {
                if (_selectedPlayer != value)
                {
                    _selectedPlayer = value;
                    OnPropertyChanged();
                }
            }
        }
        private Team _selectedTeam;
        public Team SelectedTeam
        {
            get => _selectedTeam;
            set
            {
                if (_selectedTeam != value)
                {
                    _selectedTeam = value;
                    OnPropertyChanged();
                }
            }
        }
        public ObservableCollection<Player> Players { get; private set; }
        public ObservableCollection<Team> Teams { get; private set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public ICommand AddPlayerCommand { get; }
        public ICommand ModifyPlayerCommand { get; }
        public ICommand DeletePlayerCommand { get; }
        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged();
                }
            }
        }

        public PlayerViewModel()
        {
            servicePlayer = new SPlayer();
            serviceTeam = new STeam();
            Players = new ObservableCollection<Player>(servicePlayer.GetPlayer());
            Teams = new ObservableCollection<Team>();
            var allTeams = serviceTeam.GetTeams();
            foreach (var team in allTeams)
            {
                Teams.Add(new Team(team.Name));
            }
            AddPlayerCommand = new Command(AddPlayer);
            ModifyPlayerCommand = new Command(ModifyPlayer);
            DeletePlayerCommand = new Command(DeletePlayer);
        }

        public void AddPlayer()
        {
            if (SelectedTeam != null)
            {
                servicePlayer.AddPlayer(Name, Username, SelectedTeam);
                Players.Add(new Player(Name, Username, SelectedTeam));
                ClearFields();
            }
        }

        public void ModifyPlayer()
        {
            if (SelectedPlayer != null && SelectedTeam != null)
            {
                servicePlayer.ModifyPlayer(SelectedPlayer.Id, Name, Username, SelectedTeam);
                SelectedPlayer.Name = Name;
                SelectedPlayer.Username = Username;
                SelectedPlayer.Team = SelectedTeam;
            }
        }

        public void DeletePlayer()
        {
            servicePlayer.DeletePlayer(SelectedPlayer.Id);
            Players.Remove(SelectedPlayer);
            SelectedPlayer = null;
        }

        private void ClearFields()
        {
            Name = string.Empty;
            Username = string.Empty;
            SelectedTeam = null;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
