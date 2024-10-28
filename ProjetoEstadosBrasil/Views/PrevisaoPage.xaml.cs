using ProjetoEstadosBrasil.Models;
using ProjetoEstadosBrasil.ViewModels;

namespace ProjetoEstadosBrasil.Views
{
    public partial class PrevisaoPage : ContentPage
    {
        public PrevisaoPage(PrevisaoViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private async void VoltarButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}