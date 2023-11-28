using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Uma casa decimal com arredondamento
            Console.WriteLine(valor.ToString("C")); // valor monetario, moeda definida no SO
            Console.WriteLine(valor.ToString("P")); // valor perentual, adiciona o simbolo %
            Console.WriteLine(valor.ToString("#.##")); // 2 casas decimais com arredondamento
            Console.WriteLine(valor.ToString("F2")); // 2 casas decimais com arredondamento

            CultureInfo CulturaPT = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", CulturaPT));
            CultureInfo CulturaUS = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", CulturaUS));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D5")); // com zeros a direita (5 digitos)
            double preco = 2.56;
            Console.WriteLine(preco.ToString("###.##"));
        }
    }
}
