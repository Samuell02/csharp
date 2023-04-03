using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseSQL
{
    public class Carro
    {
        string marca;
        string modelo;
        int ano;
        string cor;
        
        static void acelerar(){
            Console.WriteLine("Acelerando o carro!")
        }

        static void frear(){
            Console.WriteLine("Freando o carro!")
        }
    }
}