using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseSQL
{
    public class Calculadora
    {
        int n1;
        int n2;

        int resultado;
        static void somar(){
        Console.WriteLine("insira o primeiro numero");

        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("insira o segundo numero");

        n2 = Convert.ToInt32(Console.ReadLine());
        resultado = n1 + n2;
        Console.WriteLine("O resultado é:");

        Console.WriteLine(Resultado);
        

        }

        static void subtrair(){
        Console.WriteLine("insira o Primeiro numero;");

        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("insira o valor a ser subtraido;");

        n2 = Convert.ToInt32(Console.ReadLine());
        resultado = n1 - n2;
                Console.WriteLine("O resultado é:");

        Console.WriteLine(Resultado);
        

        }

        static void Multiplicar(){
        Console.WriteLine("Insira o primeiro numero:");

        n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira o segundo numero:");

        n2 = Convert.ToInt32(Console.ReadLine());
        resultado = n1 * n2;
                Console.WriteLine("O resultado é:");

        Console.WriteLine(Resultado);
        

        }

        static void Dividir(){
        Console.WriteLine("Insira o primeiro numero:");

        n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insira o segundo numero:");

        n2 = Convert.ToInt32(Console.ReadLine());
        resultado = n1/n2;
                Console.WriteLine("O resultado é:");

        Console.WriteLine(Resultado);
        

        }
    }
}