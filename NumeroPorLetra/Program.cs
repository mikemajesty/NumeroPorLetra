using System.Collections.Generic;
using System.Linq;
using C = System.Console;
namespace NumeroPorLetra
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "";

            do
            {

                var alfabetoLista = new List<Alfabeto>();

                char letras = 'a';
                for (int contador = 1; contador <= 26; contador++, letras++)
                {
                    var ap = new Alfabeto { Letra = letras, Numero = contador };
                    alfabetoLista.Add(ap);
                }

                C.WriteLine("Digite uma palavra");
                string palavraDigitada = C.ReadLine();
                char[] charArray = palavraDigitada.ToLower().ToCharArray();

                foreach (var item in charArray)
                {
                    if (!item.ToString().Contains(" "))
                    {
                        C.Write(alfabetoLista.FirstOrDefault(c => c.Letra == item).Numero.ToString() + " ");
                    }

                }

                C.ReadKey();
                C.WriteLine("Deseja Continuar [S/N]");
                continuar = C.ReadLine();
            } while (continuar.ToLower() == "s");
        }
        public class Alfabeto
        {
            public char Letra { get; set; }
            public int Numero { get; set; }
        }
    }
}
