using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Esport.Front.Model
{
    public class Statistic : INotifyPropertyChanged
    {
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged(); }
        }

        private string _name;

        public event PropertyChangedEventHandler? PropertyChanged;


        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        public Statistic(string name, string type)
        {
            this._name = name;
            this._type = type;
        }
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
