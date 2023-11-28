using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Inferencia {
        public static void Executar() {
            var nome = "Rogerio Coelho"; // C# toma a decisao sobre o tipo de variavel de forma implicita  
            Console.WriteLine("Variavel " + nome);
            var idade = 64;
            Console.WriteLine("idade " + idade);
            // nome = 123; vai gerar erro de compilação
            // variaveis de tipo implicito devem ser incializadas
            var texto = "texto de teste" as string;
            Console.WriteLine(texto);
        }
    }
}
