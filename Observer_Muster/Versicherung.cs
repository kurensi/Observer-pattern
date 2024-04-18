using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Muster
{
    public abstract class Versicherung
    {
        private List<Kunde> K_liste = new List<Kunde>();

        public  virtual void KundeHinzufügen(Kunde kunde)
        {
            K_liste.Add(kunde);
        }
        public virtual void KundeEntfernen(Kunde kunde)
        {
            try
            {
                Console.Write(" Geben Sie die Name des Kundes zum entfernen ein : ");
               string name = Console.ReadLine();
                int k=0;
                foreach (Kunde x in K_liste)
                {
                    if (x.name == name)
                    {
                        K_liste.Remove(kunde);
                        Console.WriteLine($"\n Kunde mit der Name {name} gelöscht !!!!");
                        break;
                    }
                    else if (k==K_liste.Count-1)
                    {
                        Console.WriteLine(" Leider ist diese Kunde nicht vorhanden !!!!!");
                    }
                    k++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public virtual void KundenBenachrichtigen(Formular formular)
        {
            foreach (Kunde kunde in K_liste)
                kunde.FormularAnKunde(formular);
        }
        public void getKunden()
        {
            Console.WriteLine("----Unser Kunden--------\n");
            int k = 1;
            foreach (var kunde in K_liste)
            {
                Console.WriteLine($"{k++}ter : {kunde.name}");
            }
        }
    }
}
