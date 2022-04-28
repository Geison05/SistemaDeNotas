using System;
using System.Globalization;
namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas N = new Notas();

            Console.Write("Nome do aluno: ");
            N.Nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            N.Nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N.Nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N.Nota3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Nota Final: "+ N.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));

            if (N.Aprovado())
                Console.WriteLine("Aprovado! ");

            else
            {
                Console.WriteLine("Reprovado! ");
                Console.WriteLine("Faltaram " + N.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)+" Pontos");
            } 
        }
    }
}