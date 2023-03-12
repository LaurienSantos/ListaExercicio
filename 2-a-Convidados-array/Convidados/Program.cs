using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] convidados = new string[5] { "Laurien", "Danilo",
            "Leonardo", "Joao", "Mariana" };

            Console.WriteLine("Conviados presentes na lista: ");
            foreach (string pessoa in convidados)
            {
               Console.WriteLine(pessoa);
            }

            Console.ReadLine();
        }
    }
}
