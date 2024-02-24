using Esport.Back.Service.Players;
using Esport.Back.Service.Teams;
using Esport.Front.Model;
using Esport.Interface;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Xml.Linq;
using Telerik.Maui.Controls;
using Telerik.Maui.Controls.Compatibility.DataGrid;

namespace Esport.Front.ViewModel
{
    public class PlayerViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly SPlayer servicePlayer;
        private readonly STeam serviceTeam;
        // Déclaration des propriétées pour stocker le joueur
        public MPlayer SelectedPlayer { get; set; }

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
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
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

        //Interface permettant de lier les boutons aux fonctions
        public ICommand AddPlayerCommand { get; }
        public ICommand ModifyPlayerCommand { get; }
        public ICommand DeletePlayerCommand { get; }

        private RadDataGrid _dataGrid;

        // Collection de toutes les équipes et Teams disponibles
        public ObservableCollection<MTeam> Teams { get; private set; }
        public ObservableCollection<MPlayer> Players { get; private set; }
        

        public PlayerViewModel()
        {
            // Initialisation des services pour les joueurs et les équipes
            servicePlayer = new SPlayer();
            serviceTeam = new STeam();

            // Récupération de la liste des joueurs et des équipes
            Players = new ObservableCollection<MPlayer>(servicePlayer.GetPlayer().Select(x=> new MPlayer(x)));
            Teams = new ObservableCollection<MTeam>(serviceTeam.GetTeams().Select(x=> new MTeam(x)));
            
            // Initialisation des commandes pour les boutons
            AddPlayerCommand = new Command(AddPlayer);
            ModifyPlayerCommand = new Command(ModifyPlayer);
            DeletePlayerCommand = new Command(DeletePlayer);
        }

        // Méthode pour ajouter un joueur
        public void AddPlayer()
        {
            if (SelectedTeam != null)
            {
                MPlayer p = new MPlayer(Name, Username, SelectedTeam);
                servicePlayer.AddPlayer(p.Id,p.Name,p.Username, p.Team);
                Players.Add(p);
                ClearFields();
            }
        }
        // Méthode pour modifier un joueur
        public void ModifyPlayer()
        {
            servicePlayer.ModifyPlayer(Id, Name, Username, SelectedTeam);
        }
        // Méthode pour supprimer un joueur
        public void DeletePlayer()
        {
            foreach (var p in servicePlayer.GetPlayerById(Id)){
                Players.Remove(new MPlayer(p));
                servicePlayer.DeletePlayer(Id);
            }
        }

        // Méthode pour effacer les champs du formulaire
        private void ClearFields()
        {
            Name = string.Empty;
            Username = string.Empty;
            SelectedTeam = null;
        }

        // Méthode pour notifier le changement de propriété
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
