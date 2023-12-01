using System.Text.Json.Serialization;

namespace BlazorAppBela.Data
{
    public class ClienteModel
    {
        public ClienteModel(string nome, string cidade, string email, string telefone, string senha, DateTime dataNascimento)
        {
            Nome = nome;
            Cidade = cidade;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            DataNascimento = dataNascimento;
        }
        public ClienteModel()
        {

        }

        [JsonPropertyName("Nome")]
        public string Nome { get; set; }


        [JsonPropertyName("Cidade")]
        public string Cidade { get; set; }


        [JsonPropertyName("Email")]
        public string Email { get; set; }


        [JsonPropertyName("Telefone")]
        public string Telefone { get; set; }


        [JsonPropertyName("Senha")]
        public string Senha { get; set; }


        [JsonPropertyName("DataNascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
