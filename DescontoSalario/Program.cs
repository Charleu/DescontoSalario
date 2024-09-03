using System;

namespace DescontoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario("Charleu", 10000.00, 20.0);
            Console.WriteLine($"O salário de {fun.Nome} é de {fun.CalcularSalarioLiquido().ToString("C")}");
            fun.AumentarSalario(15);
            Console.WriteLine($"Salário bruto é de: {fun.SalarioBruto.ToString("C")}\nSalário líquido é de: {fun.CalcularSalarioLiquido().ToString("C")}");
        }
    }
}

