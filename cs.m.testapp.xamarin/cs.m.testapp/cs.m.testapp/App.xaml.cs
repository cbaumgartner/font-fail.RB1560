using Xamarin.Forms;

[assembly: ExportFont("Futura-Std-Book-Regular.ttf", Alias = "Futura-Std-Book-Regular")]
namespace cs.m.testapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
