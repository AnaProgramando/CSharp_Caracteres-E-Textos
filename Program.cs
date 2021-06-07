using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'A';
            Console.WriteLine("Declarando a primeira letra do alfabeto como caracter temos o _" + letra + "_.");

            char valor = (char)65;
            Console.WriteLine("Transformando o número decimal 65 em char temos _" + valor + "_.");

            //valor = valor + 1;
            //Console.WriteLine(valor);
            // O código acima não compila, pois quando escrevemos essa soma, o CSharp automaticamente transforma o resultado para o maior tipo, que nesse caso é int, já que o número 1 é um inteiro.

            valor = (char)(valor + 1);
            Console.WriteLine("Transformando o número decimal 65 em char e somando com 1 temos _" + valor + "_.");
            //Aqui fizemos um casting para que esse código compile, ou seja, envolvemos a soma com parênteses, e dessa forma, dizemos para o C# que queremos transformar o resultado dessa soma em char.

            string frase = "Testes do curso de CScharp";
            Console.WriteLine("Declarando uma string temos _" + frase + "_.");
            //Imprimindo a string no console usamos obrigatóriamente aspas duplas.

            frase = frase + 100;
            Console.WriteLine("Declarando uma string e um número temos _" + frase + "_.");
            //Concatenando a string com o número, e o número aparece no final da frase, porque o CSharp converte automaticamente o número para string.


            Console.ReadLine();
        }
    }
}
