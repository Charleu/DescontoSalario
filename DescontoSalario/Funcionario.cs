using System;

namespace DescontoSalario
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

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
