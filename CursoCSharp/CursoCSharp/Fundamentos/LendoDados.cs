using System;
using System.Globalization; // metodo para usar ponto "." como separador de casas decimais
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual é sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu salário?");
            // metodo para usar ponto "." como separador de casas decimais
            // desconsidera configuração definidas no sistema operacional
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
