using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Muster
{
    public class OrkSoldat : Kunde
    {
        public string name { get; set; }
        public void FormularAnKunde(Formular formular)
        {
            Console.WriteLine($"\nSchicke Formular {formular.name} an OrkSoldat mit der Name {name} nach Luzern !!!!");   
        }
        public void nameEingeben()
        {
            Console.Write(" Geben Sie eine Name ein : ");
           name = Console.ReadLine();
        }
    }
}
