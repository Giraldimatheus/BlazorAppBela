using BlazorAppBela.Data;

namespace BlazorAppBela.Interfaces
{
    public interface IClienteAppService
    {
        Task<IList<ClienteModel>> GetAllClientesAsync();
        Task<ClienteModel> GetClienteAsync(string email);
        Task<ClienteModel> CreateClienteAsync(ClienteModel cliente);
        Task<ClienteModel> UpdateClienteAsync(ClienteModel cliente);
        Task DeleteClienteAsync(string email);
    }
}
