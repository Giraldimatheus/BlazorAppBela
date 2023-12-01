using BlazorAppBela.Data;
using BlazorAppBela.Interfaces;
using System.Net.Http;
using System.Net;
using System.Net.Http.Json;

namespace BlazorAppBela.Services
{
    public class ContatoAppService : IContatoAppService
    {
        private readonly HttpClient _httpClient;
        public ContatoAppService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ContatoModel> CreateContatoAsync(ContatoModel contato)
        {
            var response = await _httpClient.PostAsJsonAsync<ContatoModel>("Contato/PostContato", contato);
            var content = await response.Content.ReadFromJsonAsync<ContatoModel>();
            if (response.StatusCode != HttpStatusCode.OK)
                content = null;
            return content;
        }

        public async Task DeleteContatoAsync(string email)
        {
            await _httpClient.DeleteAsync($"Contato/DeleteContato/{email}");
        }

        public async Task<IList<ContatoModel>> GetAllContatosAsync()
        {
            var contatos = await _httpClient.GetFromJsonAsync<IList<ContatoModel>>("Contato/GetAllContatos");
            return contatos;
        }

        public async Task<ContatoModel> GetContatoAsync(string email)
        {
            var contatos = await _httpClient.GetFromJsonAsync<ContatoModel>($"Contato/GetContatoByEmail{email}");
            return contatos;
        }

        public async Task<ContatoModel> UpdateContatoAsync(ContatoModel contato)
        {
            var response = await _httpClient.PutAsJsonAsync<ContatoModel>("UpdateContato", contato);
            var content = await response.Content.ReadFromJsonAsync<ContatoModel>();
            return content;
        }
    }
}
