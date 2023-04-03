using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  DatabaseSQL
{
    public class Retangulo
    {
        int Mbase;
        int Altura;


        static void CalcularArea(){

        Console.Writeline(Altura*Mbase);

        }

        static void CalcularPerimetro(){

        Console.Writeline(2*(Altura+Mbase));

        }
    }
}