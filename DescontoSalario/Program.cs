using System;

namespace DescontoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario("Charleu", 10000.00, 20.0);
            Console.WriteLine($"{fun.Nome} tem um salário bruto de {fun.SalarioBruto.ToString("C")}.\nApós o desconto de {fun.Imposto}% de imposto, o salário líquido é {fun.CalcularSalarioLiquido().ToString("C")}.");

            fun.AumentarSalario(15);
            Console.WriteLine($"\nApós um aumento de 15%, o novo salário bruto de {fun.Nome} é {fun.SalarioBruto.ToString("C")}.\nO salário líquido, após o imposto, passa a ser {fun.CalcularSalarioLiquido().ToString("C")}.");
        }
    }
}

