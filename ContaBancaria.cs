using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseSQL
{
    public class ContaBancaria
    {
        int numeroDaConta;
        int saldo;

        string Titular;
        int Inserido;


        static void Depositar(){
        Console.Writeline("Olá,",Titular);

        Console.Writeline("Digite o quanto vc quer depositar");
        Inserido = Convert.ToInt32(Console.ReadLine());
        Console.Writeline("Valor"+Inserido+"Depositado com sucesso");


        }

        static void Sacar(){
        Console.Writeline("Olá,",Titular);

        Console.Writeline("Digite o quanto vc quer sacar");
        Inserido = Convert.ToInt32(Console.ReadLine());
        if (0>(Saldo - Inserido))
        {
        Console.Writeline("Saque Inválido");
        break;

        }
        Console.Writeline("Valor"+Inserido+"Saqueado com sucesso");


        }

        static void Transferir(){
        Console.Writeline("Olá,",Titular);

        Console.Writeline("Digite o quanto vc quer transferir");
        Inserido = Convert.ToInt32(Console.ReadLine());
        Console.Writeline("Digite para quem vc quer transferir");
        numeroDaConta = Convert.ToInt32(Console.ReadLine());

        if (0>(Saldo - Inserido))
        {
        Console.Writeline("Transferencia Inválida");
        break;

        }
        Console.Writeline("Valor"+Inserido+"Transferido com sucesso");


        }
    }
}