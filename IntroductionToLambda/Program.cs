using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 2: Crie uma lista de nomes de produtos e, usando expressões lambda, transforme essa lista em uma lista de strings que exibe o nome do produto e o preço formatado.
            List<(string productName, decimal price)> products = new List<(string, decimal)> { ("Apple", 1m), ("Smartphone", 800m), ("Mouse", 100m), ("Sword", 200m) };
            List<string> productsFormated = products.Select(x => $"\nProduct: {x.productName} - Price: {x.price.ToString("C2")}").ToList();

            Console.WriteLine(string.Join(", ", productsFormated));


            //Exercicio 3: Dada uma lista de funcionários, onde cada funcionário tem um nome e um salário, filtre os funcionários que ganham mais de R$ 3000, e em seguida, ordene a lista por nome.

            List<(string name, double salary)> employee = new List<(string, double)> { ("Jorge", 2500), ("Jhoyan", 4201), ("Diogo", 4020), ("Guilherme", 4200) };
            List<string> employeeOrdered = employee.Where(x => x.salary > 3000).OrderBy(x => x.name).Select(x => $"\nFuncionário: {x.name} - Salário {x.salary.ToString("C2")}").ToList();

            Console.WriteLine(string.Join(", ", employeeOrdered));


            Console.ReadKey();
        }
    }
}
