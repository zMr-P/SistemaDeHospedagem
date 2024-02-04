using SistemaDeHospedagem.Models;
using SistemaDeHospedagem.Services;

namespace HospedagemDeHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Teste 01\\

            List<Cliente> hospedes = new();

            Cliente c1 = new("Hóspede 1");
            Cliente c2 = new("Hóspede 2");

            hospedes.Add(c1);
            hospedes.Add(c2);

            Quarto quarto = new("Suíte Master", 2, 150);

            Reserva reserva = new(10);
            reserva.CadastrarQuarto(quarto);
            reserva.CadastrarHospedes(hospedes);

            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularDiaria():C}");
            Console.ReadKey();
            Console.Clear();

            //Teste 02\\

            List<Cliente> hospedes2 = new();

            Cliente c3 = new("Hóspede 3");
            Cliente c4 = new("Hóspede 4");

            hospedes2.Add(c3);
            hospedes2.Add(c4);

            Quarto quarto2 = new("Suíte Master", 1, 150);

            Reserva reserva2 = new(10);
            reserva2.CadastrarQuarto(quarto2);
            reserva2.CadastrarHospedes(hospedes2);

            Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva2.CalcularDiaria():C}");
        }
    }
}