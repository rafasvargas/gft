using System;
using jogo.src.Entities;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args){
            Knight arus = new Knight("Arus", 23, "Knight", 749, 72);   
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 601, 482);
            BlackWizard topapa = new BlackWizard("Topapa", 42, "BlackWizard", 385, 641);
            Ninja wedee = new Ninja("Wedee", 42, "Ninja", 574, 89);
            Console.WriteLine(arus.ToString());
            Console.WriteLine(arus.Attack());
            Console.WriteLine();
            Console.WriteLine(wizard.ToString());
            Console.WriteLine(wizard.Attack(3));
            Console.WriteLine();
            Console.WriteLine(topapa.ToString());
            Console.WriteLine(topapa.Attack(5));
            Console.WriteLine();
            Console.WriteLine(wedee.ToString());
            Console.WriteLine(wedee.Attack());


        }
    }
}