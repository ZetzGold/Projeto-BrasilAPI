using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ProjetoEstadosBrasil.Models;
using Newtonsoft.Json;

public class CidadeService
{
    private readonly HttpClient _httpClient;

    public CidadeService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Cidade>> ObterCidadePorNome(string cityName)
    {
        try
        {
            var response = await _httpClient.GetAsync($"https://brasilapi.com.br/api/cptec/v1/cidade/{cityName}");

            if (response.IsSuccessStatusCode)
            {
                // Lê o conteúdo como uma lista de Cidade
                var cidades = await response.Content.ReadFromJsonAsync<List<Cidade>>();
                // Retorna a lista completa de cidades ou uma lista vazia se a lista estiver vazia
                return cidades ?? new List<Cidade>();
            }
        }
        catch (Exception ex)
        {
            // Aqui você pode logar o erro ou tratá-lo de alguma forma
            Console.WriteLine($"Erro ao obter cidades: {ex.Message}");
        }

        // Retorna uma lista vazia em caso de erro ou falha
        return new List<Cidade>();
    }

    public async Task<List<Clima>> ObterClima(int cityCode)
    {
        var response = await _httpClient.GetAsync($"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{cityCode}");
        if (response.IsSuccessStatusCode)
        {
            var climaResponse = await response.Content.ReadFromJsonAsync<ClimaResponse>();
            return climaResponse?.Clima; // Retorna apenas a lista de clima
        }
        return null;
    }

    public async Task<Previsao> ObterPrevisao(int cityCode)
    {
        var response = await _httpClient.GetAsync($"https://brasilapi.com.br/api/cptec/v1/clima/previsao/{cityCode}/5");
        if (response.IsSuccessStatusCode)
        {
            var previsao = await response.Content.ReadFromJsonAsync<Previsao>();
            return previsao; // Retorna o objeto Previsao que contém a lista de Clima
        }
        return null;
    }

}