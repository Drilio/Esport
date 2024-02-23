using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Esport.Back.Service.Games;
using Esport.Back.Service.Teams;
using Esport.Back.Service.VideoGames;
using Esport.Front.Model;

namespace Esport.Front.ViewModel
{
    public class StatisticsViewModel : INotifyPropertyChanged
    {
        //Déclaration des variables
        public ICommand CreateGame {  get; set; }
        public List<MTitleVideoGame> PickerVideoGame { get; set; }
        public List<string> PickerWinLoose { get; set; } = new List<string> { "Win", "GROS LOOSER TU PUES" };

        private SGetVideoGame _getVideoGame = new SGetVideoGame();

        private SCreateGame _createGame = new SCreateGame();

        private SGetAllGames _getAllGames = new SGetAllGames();

        private SGetTeamsNames _getTeamsNames = new SGetTeamsNames();
        public MGame GameToCreate { get; set; }
        public List<MGame> ListOfAllGames { get; set; }

        public List<string> AllTeamsNames { get; set; }
        private ObservableCollection<MGame> ObservableGame { get; set;}
        //Permet de créer un jeu
        public void AddGame()
        {
            ObservableGame.Add(GameToCreate);
            _createGame.SaveGame(GameToCreate);
        }

        //Permet de récupérer les données necessaire à la Vew 
        internal void LoadData()
        {
            //Récupération de tous les jeux vidéo disponibles
            //TODO:THIS FIRST LINE MAY BE USELESS
            var AllVideoGame = _getVideoGame.GetAllTitleVideoGame();
            this.PickerVideoGame = _getVideoGame.GetAllTitleVideoGame().Select(T => new MTitleVideoGame(T)).ToList();
            //Récupération de toutes les parties de jeux sauvegardé
            //TODO:THIS FIRST LINE MAY BE 
            var AllGames = _getAllGames.GetAllGames();
            this.ListOfAllGames = _getAllGames.GetAllGames()
                .Select(g => new MGame(g))
                .ToList();
            //Récupération des équipe
            this.AllTeamsNames = _getTeamsNames.GetTeamsName();
        }

        //Constructeur Statistics
        public StatisticsViewModel() {
            LoadData();
            CreateGame = new Command(AddGame);
        }

        //Logique qui permet d'implementer des Listeners sur le changement des propriétées 
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

