using System;
using System.Globalization;

namespace POO_pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosBancarios p1;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial? ");
            char dep =char.Parse(Console.ReadLine());

            //--------------------------------------------
            if (dep == 's' || dep == 'S')
            {
                Console.Write("Entre o valor para o deposito incial:");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p1 = new DadosBancarios(titular, numero, depositoInicial);
            }
            else
            {
                p1 = new DadosBancarios(titular, numero);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(p1);
            Console.WriteLine();

            //-------------------------------------------------

            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            p1.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(p1);
            Console.WriteLine();

            //----------------------------------------------------

            Console.Write("Entre um valor para saque:");
            double saque = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            p1.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(p1);
        }
    }
}
