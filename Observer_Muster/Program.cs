using System;

namespace Observer_Muster
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto_Versicherung Premium = new Auto_Versicherung();
            Kunde Ork_General = new OrkGeneral();
            Ork_General.nameEingeben();
            Kunde Ork_Soldat = new OrkSoldat();
            Ork_Soldat.nameEingeben();

            Premium.KundeHinzufügen(Ork_General);
            Premium.KundeHinzufügen(Ork_Soldat);
           

            Formular New_Formular = new Formular(" Auto_Pannen_Transport");
            Premium.setFormular(New_Formular);
            Premium.getKunden();
            Premium.KundeEntfernen(Ork_Soldat);
            Premium.getKunden();

            Console.ReadKey();
        }
    }
}
