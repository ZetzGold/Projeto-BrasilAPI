using ProjetoEstadosBrasil.Views;

namespace ProjetoEstadosBrasil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
