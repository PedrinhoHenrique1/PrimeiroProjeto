using System.Threading.Channels;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Pedro";
            string cidade = "Campos do Jordão";
            int idade = 15;

            Console.WriteLine("Digite seu nome: "); nome = Console.ReadLine();
            Console.WriteLine("Digite seu idade: "); idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua cidade: "); cidade = Console.ReadLine();
        }
    }
}
