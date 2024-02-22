using Esport.Back.Services;
using Esport.Front.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Telerik.Maui.Controls;

namespace Esport.Front.ViewModel
{
    internal class PlayerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private readonly SPlayer servicePlayer;

        public ObservableCollection<Player> Players { get; private set; }

        public string Name { get; set; }
        public string Username { get; set; }
        public Team Team { get; set; }

        public ICommand AddPlayerCommand { get; }
        public ICommand ModifyPlayerCommand { get; }
        public ICommand DeletePlayerCommand { get; }

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

        public PlayerViewModel()
        {
            servicePlayer = new SPlayer();
            Players = new ObservableCollection<Player>();
            AddPlayerCommand = new Command(AddPlayer);
            ModifyPlayerCommand = new Command(ModifyPlayer);
            DeletePlayerCommand = new Command(DeletePlayer);
        }

        public void AddPlayer()
        {
            servicePlayer.AddPlayer(Name, Username, Team);
            Players.Add(new Player(Name, Username, Team));
            ClearFields();
        }

        public void ModifyPlayer()
        {
            servicePlayer.ModifyPlayer(SelectedPlayer.Id, Name, Username, Team);
            SelectedPlayer.Name = Name;
            SelectedPlayer.Username = Username;
            SelectedPlayer.Team = Team;
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
            Team = null;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
