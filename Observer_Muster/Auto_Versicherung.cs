using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Muster
{
    public class Auto_Versicherung : Versicherung
    {
        public Formular gültigesFormular;
        public void setFormular(Formular formular)
        {
            gültigesFormular = formular;
            KundenBenachrichtigen(formular);

        }
        public Formular getFormular()
        {
            return gültigesFormular;
        }

    }
}
