using System;

namespace DescontoSalario
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double CalcularSalarioLiquido() => SalarioBruto * (1 - Imposto / 100);

        public void AumentarSalario(double porcentagem) => SalarioBruto *= 1 + porcentagem / 100;
    }
}
