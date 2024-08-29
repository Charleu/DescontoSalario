using System;

namespace DescontoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Salário bruto:");
            double salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto:");
            double imposto = double.Parse(Console.ReadLine());

            Funcionario func = new Funcionario(nome, salarioBruto, imposto);

            Console.WriteLine($"\nFuncionário:\nNome: {func.Nome}\nSalário Líquido: {func.CalcularSalarioLiquido():C}");
            Console.WriteLine("\nInforme a porcentagem de aumento:");
            func.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine($"\nDados do funcionário atualizados:\nNome: {func.Nome}\nSalário atualizado: {func.CalcularSalarioLiquido():C}");
        }
    }
}

