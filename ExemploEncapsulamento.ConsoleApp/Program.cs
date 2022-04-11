using System;

namespace ExemploEncapsulamento.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) //Encapsulamento é restringir o acesso a informação que vc tem suas classes
        {
            Aluno a = new Aluno();
            a.mensagem();

            Console.ReadLine();
        }
    }
}
