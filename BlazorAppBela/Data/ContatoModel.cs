using System.Text.Json.Serialization;

namespace BlazorAppBela.Data
{
    public class ContatoModel
    {
        public ContatoModel(string nome, string relacionamento, string email, string telefone, string emailClienteConexao)
        {
            Nome = nome;
            Relacionamento = relacionamento;
            Email = email;
            Telefone = telefone;
            EmailClienteConexao = emailClienteConexao;
        }
        public ContatoModel()
        {

        }
        [JsonPropertyName("Nome")]
        public string Nome { get; set; }

        [JsonPropertyName("Relacionamento")]
        public string Relacionamento { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonPropertyName("Telefone")]
        public string Telefone { get; set; }

        [JsonPropertyName("EmailClienteConexao")]
        public string EmailClienteConexao { get; set; }
    }
}
