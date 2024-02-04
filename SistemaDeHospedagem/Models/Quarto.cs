namespace SistemaDeHospedagem.Models
{
    public class Quarto
    {
        public string TipoQuarto { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria {  get; set; }

        public Quarto(string tipoQuarto, int capacidade, decimal valorDiaria)
        {
            TipoQuarto = tipoQuarto;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}
