﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lista_com_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List <string> Convidados = new List<string> ();

            Convidados.Add("Ahri");
            Convidados.Add("Morgana");
            Convidados.Add("Sett");
            Convidados.Add("Yuumi");
            Convidados.Add("Seraphine");

            Console.WriteLine("Sua lista possui " + Convidados.Count + " convidados que são: ");
            foreach (string item in Convidados)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
