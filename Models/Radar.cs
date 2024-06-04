using Newtonsoft.Json;

namespace Models
{
    public class Radar
    {
        public readonly string Insert = "INSERT INTO TB_CAR (name, color, year, insurenceId) VALUES ";

        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("concessionaria")]
        public string Concessionaria { get; set; }

        [JsonProperty("ano_do_pnv_snv")]
        public int ano_do_pnv_snv { get; set; }

        [JsonProperty("tipo_de_radar")]
        public string tipo_de_radar { get; set; }

        [JsonProperty("rodovia")]
        public string Rodovia { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("km_m")]
        public double km_m { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("tipo_pista")]
        public string tipo_pista { get; set; }

        [JsonProperty("sentido")]
        public string Sentido { get; set; }

        [JsonProperty("situacao")]
        public string Situacao { get; set; }

        [JsonProperty("data_da_inativacao")]
        public DateTime[] data_da_inativacao { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("velocidade_leve")]
        public int velocidade_leve { get; set; }

    }
}
