using Empresa.Entidades;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();

            Console.WriteLine("Entre com o numero de funcionarios: ");
            int fun = int.Parse(Console.ReadLine());

            for (int i = 1; i <= fun; i++)
            {
                Console.WriteLine($"Funcionario #{i} dados");
                Console.Write("é terceirizado ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Valor adicional: ");
                    double adicionalValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new FuncionarioTerceirizado(nome, horas, valorPorHora, adicionalValor));
                }
                else 
                {
                    lista.Add(new Funcionario(nome, horas, valorPorHora));
                }

            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");

            foreach (Funcionario fu in lista)
            {
                Console.WriteLine(fu.Nome + " - $ " + fu.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }




        }
    }
}
