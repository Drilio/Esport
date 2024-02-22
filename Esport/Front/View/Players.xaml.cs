using Esport.Front.ViewModel;

namespace Esport.Front.View
{
    public partial class Player : ContentPage
    {
        public Player()
        {
            InitializeComponent();
            BindingContext = new PlayerViewModel();
        }
    }

}
