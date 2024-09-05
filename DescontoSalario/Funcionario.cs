using System;

namespace DescontoSalario
{
    public class Funcionario
    {
        private string _nome;
        private double _salarioBruto;
        private double _imposto;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double SalarioBruto
        {
            get { return _salarioBruto; }
            set { _salarioBruto = value; }
        }

        public double Imposto
        {
            get { return _imposto; }
            set { _imposto = value; }
        }

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double CalcularSalarioLiquido() => SalarioBruto * (100 - Imposto) / 100;

        public void AumentarSalario(double porcentagem) => SalarioBruto += SalarioBruto * porcentagem / 100;

    }
}
