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

        private SCreateGame _CreateGame = new SCreateGame();
        public MGame GameToCreate { get; set; }

        private ObservableCollection<MGame> ObservableGame { get; set;}
        //Permet de créer un jeu
        public void AddGame()
        {
            ObservableGame.Add(GameToCreate);
            _CreateGame.SaveGame(GameToCreate);
        }

        //Permet de récupérer les "videosGames" existant
        internal void LoadData()
        {
            var toto = _getVideoGame.GetAllTitleVideoGame();
            this.PickerVideoGame = _getVideoGame.GetAllTitleVideoGame().Select(T => new MTitleVideoGame(T)).ToList();
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

