using M_PriceCheker.MVVM.views;

namespace M_PriceCheker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new settings());
        }
    }
}
