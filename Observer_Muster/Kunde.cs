using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Muster
{
    
    public interface Kunde
    {
        string name { get; set; }
        public void FormularAnKunde(Formular formular);
        public void nameEingeben();
    }
}
