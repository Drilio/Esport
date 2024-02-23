using Esport.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Front.Model
{
    public class MGame : INotifyPropertyChanged, IGame
    {
        private int _id { get; set; }
        public int Id
        {
            get { return _id; }
            set { _id = value;
                OnPropertyChanged();
            }
        }
        private int _idVideoGame { get; set; }
        public int IdVideoGame
        {
            get { return _idVideoGame; }
            set
            {
                _idVideoGame = value;
                OnPropertyChanged();
            }
        }
        private List<int> _playersId { get; set; }
        public List<int> PlayersId
        {
            get { return _playersId; }
            set
            {
                _playersId = value;
                OnPropertyChanged();
            }
        }
        private List<int> _teamsId { get; set; }
        public List<int> TeamsId
        {
            get { return _teamsId; }
            set
            {
                _teamsId = value;
                OnPropertyChanged();
            }
        }
        private int _winnerTeamId { get; set; }
        public int WinnerTeamId
        {
            get { return _winnerTeamId; }
            set
            {
                _winnerTeamId = value;
                OnPropertyChanged();
            }
        }
        private DateTime _date { get; set; }
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }


        public MGame(IGame Game) {
        this._id = Game.Id;
        this._idVideoGame = Game.IdVideoGame;
        this._playersId = Game.PlayersId;
        this._teamsId = Game.TeamsId;
        this._winnerTeamId = Game.WinnerTeamId;
        this._date = Game.Date;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
