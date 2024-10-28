using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProjetoEstadosBrasil.Models;
using ProjetoEstadosBrasil.Views; // Adicione este using para a navegação

namespace ProjetoEstadosBrasil.ViewModels
{
    public partial class CidadeClimaViewModel : ObservableObject
    {
        private readonly CidadeService _cidadeService;
        private readonly INavigation _navigation; // Adicione esta variável para navegação

        [ObservableProperty]
        private ObservableCollection<Cidade> _cidades = new ObservableCollection<Cidade>();

        [ObservableProperty]
        private List<Clima> _clima;

        [ObservableProperty]
        private Previsao _previsao;

        public CidadeClimaViewModel(CidadeService cidadeService, INavigation navigation)
        {
            _cidadeService = cidadeService;
            _navigation = navigation; // Inicialize a variável de navegação
        }

        [RelayCommand]
        public async Task BuscarCidade(string cityName)
        {
            var cidades = await _cidadeService.ObterCidadePorNome(cityName);
            Cidades.Clear();
            foreach (var cidade in cidades)
            {
                Cidades.Add(cidade);
            }

            if (Cidades.Count > 0)
            {
                Clima = await _cidadeService.ObterClima(Cidades[0].Id);
                Previsao = await _cidadeService.ObterPrevisao(Cidades[0].Id);
            }
        }

        [RelayCommand]
        public async Task NavigateToPrevisao(Cidade cidade)
        {
            await _navigation.PushAsync(new PrevisaoPage(new PrevisaoViewModel(cidade)));
        }
    }
}