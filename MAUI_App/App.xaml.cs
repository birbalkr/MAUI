namespace MAUI_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navbar= new NavigationPage(new MainPage());
            navbar.BarBackground= Colors.Red;

            MainPage = new PresentationControl();
        }
    }
}
