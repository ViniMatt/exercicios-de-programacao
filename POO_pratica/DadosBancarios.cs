using System.Globalization;

namespace POO_pratica
{
    class DadosBancarios
    {
        //objetos
        public string Titular { get; set; }
        public int Numero { get;private set; }
        public double Saldo { get; private set; }

        //construtores
        public DadosBancarios(string nome, int numero)
        {
            Titular = nome;
            Numero = numero;
        }

        public DadosBancarios(string nome, int numero, double saldo) : this(nome, numero)
        { 
           Saldo = saldo;
        }

        //metodos
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return $"Conta: {Numero}, " +
                $"Titular: {Titular}, " +
                $"Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
