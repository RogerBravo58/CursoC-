﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            //calcular preco com desconto
            var preco = 1000.00;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preco final é: {0}", totalComDesconto);

            //IMC
            double peso = 87.5;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("IMC = {0}", imc);
            Console.WriteLine($"IMC = {imc}.");

            //Numero par impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0} / 2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0} / 2 tem resto {1}", impar, impar % 2);
        }
    }
}
