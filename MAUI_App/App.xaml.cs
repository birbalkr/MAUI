using MAUI_App.MVVM.Views;
using Plugin.Fingerprint;

namespace MAUI_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navbar= new NavigationPage(new MainPage());
            navbar.BarBackground= Colors.Red;

            MainPage =new FirstPage(CrossFingerprint.Current);
        }
    }
}
