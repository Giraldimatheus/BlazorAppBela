using BlazorAppBela.Data;

namespace BlazorAppBela.Interfaces
{
    public interface IContatoAppService
    {
        Task<IList<ContatoModel>> GetAllContatosAsync();
        Task<ContatoModel> GetContatoAsync(string email);
        Task<ContatoModel> CreateContatoAsync(ContatoModel contato);
        Task<ContatoModel> UpdateContatoAsync(ContatoModel contato);
        Task DeleteContatoAsync(string email);
    }
}
