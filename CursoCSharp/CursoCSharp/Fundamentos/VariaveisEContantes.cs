using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia
            double raio = 4.5; //8 bytes
            const double PI = 3.14;
            double area = raio * PI * PI;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);
            Console.WriteLine("concatena 1000 Area é " + area + 1000);
            Console.WriteLine("somada 1000 Area é " + (area + 1000));

            //tipos internos
            bool estaChovendo = true;
            Console.WriteLine("esta chovendo " + estaChovendo);

            //tipos inteiros
            byte idade = 45;
            Console.WriteLine("idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue; //byte com sinal
            Console.WriteLine("saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario " + salario);
            salario = short.MinValue;
            Console.WriteLine("salario " + salario);

            //mais usado dos inteiros
            int menorValorInt = int.MinValue;
            Console.WriteLine("menor inteiro " + menorValorInt);

            uint Populacao = uint.MaxValue; //inteiro sem sinal
            Console.WriteLine("Populacao " + Populacao);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("Populacao Mundial " + populacaoMundial);

            //numeros reais
            float precoDoComputador = 1299.99f; //4 bytes (evitar mover doble)
            Console.WriteLine("preco do computador " + precoDoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.12; // mais usado do reais
            Console.WriteLine("Valor De Mercado Da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre Estrelas " +  distanciaEntreEstrelas);

            //Caracteres
            char letra = 'A';
            Console.WriteLine("letra " +  letra);

            string texto = "bem vindo ao curso de C#";
            Console.WriteLine(texto);

        }
    }
}