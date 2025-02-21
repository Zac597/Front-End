using System.Globalization;
using System.Text.RegularExpressions;

namespace Testes;

public class SeuNome
{
    static void Main()
    {

        //Exercicio nomes

        //Console.Write("Digite seu nome: ");
        //string name = Console.ReadLine();
        //Console.WriteLine($"Olá, {name}!");

        //Console.Write("E qual seu sobrenome? ");
        //string subName = Console.ReadLine();
        //Console.WriteLine($"Então você se chama, {name + subName} legal!");


        //Operações Matemáticas

        //double num1 = 3;
        //double num2 = 0;
        //double sum = num1 + num2;
        //double sub = num1 - num2;
        //double div = num1 / num2;
        //double med = (num1 + num2) / 2;


        //Console.WriteLine(sum);
        //Console.WriteLine(sub);
        //if (num1 == 0 || num2 == 0)
        //{
        //Console.WriteLine("Um dos números escolhidos é zero e todo número dividido por 0 é igual a 1.");
        //}
        //else 
        //{
        //Console.WriteLine(div);
        //}
        //Console.WriteLine(med);


        //Retornar numero de letras usadas

        //Console.WriteLine("Digite quantas palavras você quiser:");
        //string Words = Console.ReadLine();

        //string RemoveWords = Words.Replace(" ", "");
        //int WordCount = RemoveWords.Count();

        //Console.WriteLine(WordCount);


        //Testes de placas

        //Console.WriteLine("Digite a sua placa para a verificação");
        //var Placa = Console.ReadLine();
        //string RemoveSpaceBetwen = Placa.Replace(" ", "");
        //var PlacaConf = RemoveSpaceBetwen.Count();
        //var PlacaFinal = Regex.IsMatch(RemoveSpaceBetwen, @"^[A-Za-z]{3}\d{4}$");
        //if (PlacaConf > 7)
        //{
        //    Console.WriteLine("Sua placa é inválida");
        //}
        //else if (PlacaFinal)
        //{
        //    Console.WriteLine("Sua placa é válida");
        //}
        //else { 
        //    Console.WriteLine("sua placa é inválida");
        //}


        //Lidando com horas

        //DateOnly dia = new DateOnly(2023, 12, 1);
        //DateTime dia1 = new DateTime(2023, 12, 1, 10, 30, 57);

        //string completFormat = dia1.ToString("F", new CultureInfo("pt-br"));
        //string formatBrazil = dia.ToString(new CultureInfo("pt-br"));
        //string hour = dia1.ToString("T");
        //string longDate = dia.ToLongDateString();

        //Console.WriteLine(completFormat);
        //Console.WriteLine(formatBrazil);
        //Console.WriteLine(hour);
        //Console.WriteLine(longDate);
    }
}
