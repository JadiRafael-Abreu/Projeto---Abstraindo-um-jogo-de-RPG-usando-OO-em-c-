using System;
using Projeto_RPG.src.Entities;

namespace Projeto_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WhiteWizard jenica = new WhiteWizard("Jenica",42,601,"White Wizard","Magia");
            Knight arus = new Knight("Arus",42,749,"Knight","Espada");
            Ninja wedge = new Ninja("Wedge",42,574,"Ninja","Nunchaku");
            BlackWizard topapa = new BlackWizard("Topapa",42,385,"Black Wizard","Magia");

            Console.WriteLine(jenica);
            Console.WriteLine(arus);
            Console.WriteLine(wedge);
            Console.WriteLine(topapa);
            
            Console.WriteLine(jenica.Attack());
            Console.WriteLine(jenica.Attack(3));
            Console.WriteLine(jenica.Attack(7));
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(arus.Attack(3));
            Console.WriteLine(arus.Attack(7));

            Console.WriteLine(wedge.Attack());
            Console.WriteLine(wedge.Attack(3));
            Console.WriteLine(wedge.Attack(7));

            Console.WriteLine(topapa.Attack());
            Console.WriteLine(topapa.Attack(3));
            Console.WriteLine(topapa.Attack(7));

        }
    }
}
