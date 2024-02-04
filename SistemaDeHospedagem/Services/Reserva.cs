using SistemaDeHospedagem.Models;

namespace SistemaDeHospedagem.Services
{
    public class Reserva
    {
        public List<Cliente> Hospedes {  get; set; }
        public Quarto QuartoCadastrado { get; set; }

        public int DiasReservados { get; set; }
        public Reserva()
        {

        }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Cliente> hospedes)
        {
            try
            {
                if (hospedes.Count <= QuartoCadastrado.Capacidade)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    throw new Exception("Quantidade de hóspedes maior que a capacidade do quarto.");
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
        public void CadastrarQuarto(Quarto quarto)
        {
            QuartoCadastrado = quarto;
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
        public decimal CalcularDiaria()
        {
            decimal diaria = QuartoCadastrado.ValorDiaria * DiasReservados;

            if (DiasReservados >= 10)
            {
                diaria -= diaria * 10 / 100;
            }

            return diaria;
        }
    }
}
