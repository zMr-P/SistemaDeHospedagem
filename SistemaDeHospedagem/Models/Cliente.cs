namespace SistemaDeHospedagem.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public Cliente()
        {

        }
        public Cliente(string nome)
        {
            Nome = nome;
        }
        public Cliente ( string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}
