using System;
using System.Collections.Generic;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employes will be registred? ");
            int qtdEmp = int.Parse(Console.ReadLine());

            List<Funcionario> Funcs = new List<Funcionario>();
            for (int i = 1; i <= qtdEmp; i++)
            {
                Console.WriteLine("Employe #" + (i) + ":");

                Console.Write("Id: "); int vId = int.Parse(Console.ReadLine());
                Console.Write("Name: "); string vName = Console.ReadLine();
                Console.Write("Salary: "); double vSalary = double.Parse(Console.ReadLine());
                //Acrescenta utilizando o construtor.
                Funcs.Add(new Funcionario(vId, vName, vSalary));
                Console.WriteLine(); //Pular linha.
            }
            //Increase salary.
            Console.Write("Enter the employe Id that will have salary increase: ");
            int RegFunc = int.Parse(Console.ReadLine());

            Funcionario emp = Funcs.Find(x => x.Id == RegFunc);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double Percent = double.Parse(Console.ReadLine());
                emp.increaseSalary(Percent);
            }
            else
            {
                Console.WriteLine("This is does not exist!");
            }

            //Update list
            Console.WriteLine(); //Pular linha.
            Console.WriteLine("Update list of employes: ");
            foreach (Funcionario obj in Funcs)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
