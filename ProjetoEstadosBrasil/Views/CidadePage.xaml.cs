using ProjetoEstadosBrasil.Models;
using ProjetoEstadosBrasil.ViewModels;

namespace ProjetoEstadosBrasil.Views
{
    public partial class CidadePage : ContentPage
    {
        public CidadePage()
        {
            InitializeComponent();

            // Inicializa o servi�o
            CidadeService cidadeService = new CidadeService();

            // Passa o servi�o e a navega��o para o ViewModel
            BindingContext = new CidadeClimaViewModel(cidadeService, Navigation);
        }
    }
}