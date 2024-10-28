using ProjetoEstadosBrasil.Models;
using ProjetoEstadosBrasil.ViewModels;

namespace ProjetoEstadosBrasil.Views
{
    public partial class CidadePage : ContentPage
    {
        public CidadePage()
        {
            InitializeComponent();

            // Inicializa o serviço
            CidadeService cidadeService = new CidadeService();

            // Passa o serviço e a navegação para o ViewModel
            BindingContext = new CidadeClimaViewModel(cidadeService, Navigation);
        }
    }
}