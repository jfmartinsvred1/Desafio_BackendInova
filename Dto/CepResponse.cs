using System.Text.Json.Serialization;

namespace Desafio_Backend.Dto
{
    public class CepResponse
    {
<<<<<<< HEAD
        //Propriedades Retornadas Na Api
=======
>>>>>>> 9b4c998 (Cep implementado)
        public string? Cep { get; set; }

        public string? Logradouro { get; set; }

        public string? Complemento { get; set; }

        public string? Bairro { get; set; }

        public string? Localidade { get; set; }

        public string? Uf { get; set; }
        [JsonIgnore]
        public string? Ibge { get; set; }
        [JsonIgnore]
        public string? Gia { get; set; }
        [JsonIgnore]
        public string? Ddd { get; set; }
        [JsonIgnore]
        public string? Siafi { get; set; }
    }
}
