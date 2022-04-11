﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento.ConsoleApp
{
    class Aluno
    {
        //atributos
        private double nota1, nota2;

        //media
        private double media() //deixamos private pois apenas o Aluno.cs vai utilizar
        {
            return (nota1 + nota2)/2;
        }

        //Mensagem
        public void mensagem()
        {
            Console.WriteLine("Informe a primeira nota");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A média é " + media());
        }
    }
}
