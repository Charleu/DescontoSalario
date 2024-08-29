using System;

namespace DescontoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            Console.WriteLine("Nome:");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto:");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto:");
            func.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nFuncionário:\nNome: {func.Nome}\nSalário Líquido: {func.CalcularSalarioLiquido():C}");
            Console.WriteLine("\nInforme a porcentagem de aumento:");
            func.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine($"\nDados do funcionário atualizados:\nNome: {func.Nome}\nSalário atualizado: {func.CalcularSalarioLiquido():C}");
        }
    }
}