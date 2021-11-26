using System;
using System.Collections.Generic;

namespace dotnetcore
{
    class Program
    {
        const float NOTA_PRA_PASSAR = 7;

        static void Main(string[] args)
        {
            var notasBronza = new List<float>();
            float mediaBronza = 0;

            var notasZuqui = new List<float>();
            float mediaZuqui = 0;

            Console.WriteLine("-- Bem vindo ao final do ano --");
            
            Console.WriteLine("\nZuqui, Digite suas notas: ");
            notasZuqui = ReceberNotas(3);
            mediaZuqui = CalcularMedia(notasZuqui);
            
            Console.WriteLine("\nBronza, Digite suas notas: ");
            notasBronza = ReceberNotas(2);
            mediaBronza = CalcularMedia(notasBronza);

            Console.WriteLine("--- Resultados ----");
            Console.WriteLine(MensagemFinal("Zuqui", mediaZuqui));
            Console.WriteLine(MensagemFinal("Bronza", mediaBronza));
        }

        private static string MensagemFinal(string nome, float media) {
            var resultado = media >= NOTA_PRA_PASSAR ? "passou!" : "reprovou, estude mais no proximo ano.";
            return $"{nome}, você tirou {media} e {resultado}";
        }

        private static List<float> ReceberNotas(int pTam) {
            var notas = new List<float>();
            
            for (int i = 0; i < pTam; i++) {
                Console.Write($"> Nota {i + 1}: ");
                notas.Add(float.Parse(Console.ReadLine()));
            }

            return notas;
        }

        private static float CalcularMedia(List<float> notas) {
            var total = 0;
            
            foreach(var nota in notas)
            {
                total += (int) nota;
            }
            
            return total / notas.Count;
        }
    }
}
