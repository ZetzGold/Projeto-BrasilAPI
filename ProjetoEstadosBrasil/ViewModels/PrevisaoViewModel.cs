using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProjetoEstadosBrasil.Models;

namespace ProjetoEstadosBrasil.ViewModels
{
    public partial class PrevisaoViewModel : ObservableObject
    {
        private readonly CidadeService _cidadeService;
        private readonly Cidade _cidade;

        [ObservableProperty]
        private Previsao _previsao;

        public PrevisaoViewModel(Cidade cidade)
        {
            _cidadeService = new CidadeService();
            _cidade = cidade;
            LoadPrevisao();
        }

        private async Task LoadPrevisao()
        {
            Previsao = await _cidadeService.ObterPrevisao(_cidade.Id);
        }
    }
}