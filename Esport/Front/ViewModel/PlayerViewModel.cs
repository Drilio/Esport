using Esport.Back.Service.Players;
using Esport.Back.Service.Teams;
using Esport.Front.Model;
using Esport.Interface;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Telerik.Maui.Controls;

namespace Esport.Front.ViewModel
{
    public class PlayerViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private readonly SPlayer servicePlayer;
        private readonly STeam serviceTeam;

        private MPlayer _selectedPlayer;
        public MPlayer SelectedPlayer
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
        private MTeam _selectedTeam;
        public MTeam SelectedTeam
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
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; 
                    OnPropertyChanged();
            }
        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; 
                    OnPropertyChanged();
            }
        }
        

        private bool _isSelected;
                public bool IsSelected
                {
                    get => _isSelected;
                    set
                    {
                        if (_isSelected != value)
                        {
                            _isSelected = value;
                            OnPropertyChanged(nameof(IsSelected));
                        }
                    }
                }
        //Interface permettant de lier les boutons aux fonctions
        public ICommand AddPlayerCommand { get; }
        public ICommand ModifyPlayerCommand { get; }
        public ICommand DeletePlayerCommand { get; }

        //
        public ObservableCollection<MTeam> Teams { get; private set; }
        public ObservableCollection<MPlayer> Players { get; private set; }
        

        public PlayerViewModel()
        {
            servicePlayer = new SPlayer();
            serviceTeam = new STeam();
            
            Players = new ObservableCollection<MPlayer>(servicePlayer.GetPlayer().Select(x=> new MPlayer(x)));
            Teams = new ObservableCollection<MTeam>();
            foreach (var team in serviceTeam.GetTeams())
            {
                Teams.Add(new MTeam(team));
            }
            AddPlayerCommand = new Command(AddPlayer);
            ModifyPlayerCommand = new Command(ModifyPlayer);
            DeletePlayerCommand = new Command(DeletePlayer);
        }

        //Fonctions permettant l'ajout, la suppression et la modification d'un joueur
        public void AddPlayer()
        {
            if (SelectedTeam != null)
            {
                servicePlayer.AddPlayer(Name=_name, Username=_username, SelectedTeam=_selectedTeam);
                Players.Add(new MPlayer(Name, Username, SelectedTeam));
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
                SelectedPlayer.Team = new Back.Persistence.CRUD.DataTransferObject.DTOTeam( SelectedTeam);
            }
        }

        public void DeletePlayer()
        {
            if (IsSelected)
            {
                Players.Remove(SelectedPlayer);
                servicePlayer.DeletePlayer(SelectedPlayer.Id);
            }
            SelectedPlayer = null;
        }

        //Permet de remettre les champs vides
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
