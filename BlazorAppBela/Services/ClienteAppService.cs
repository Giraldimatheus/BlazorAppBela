using BlazorAppBela.Data;
using BlazorAppBela.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Net.Mail;
using System.Text.Json.Serialization;
using System.Web;

namespace BlazorAppBela.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly HttpClient _httpClient;
        public ClienteAppService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ClienteModel> CreateClienteAsync(ClienteModel cliente)
        {
            var response = await _httpClient.PostAsJsonAsync<ClienteModel>("Cliente/PostCliente", cliente);
            var content = await response.Content.ReadFromJsonAsync<ClienteModel>();
            if (response.StatusCode != HttpStatusCode.OK)
                content = null;
            return content;
        }

        public async Task DeleteClienteAsync(string email)
        {
            await _httpClient.DeleteAsync($"Cliente/DeleteCliente/{email}");
        }

        public async Task<IList<ClienteModel>> GetAllClientesAsync()
        {
            var clientes = await _httpClient.GetFromJsonAsync<IList<ClienteModel>>("Cliente/GetAllAsync");
            return clientes;
        }

        public async Task<ClienteModel> GetClienteAsync(string email)
        {
            ClienteModel? cliente = await _httpClient.GetFromJsonAsync<ClienteModel>($"Cliente/GetByEmail/{email}");

            return cliente;
        }

        public async Task<ClienteModel> UpdateClienteAsync(ClienteModel cliente)
        {
            var response = await _httpClient.PutAsJsonAsync<ClienteModel>("UpdateCliente", cliente);
            var content = await response.Content.ReadFromJsonAsync<ClienteModel>();
            return content;
        }
    }
}
