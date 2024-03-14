using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prim_wf
{
    internal class CElement
    {
        //folosim un delegat de tipul action (o functie void) care priemste doar noul intreg care a fost asociat atibutului din clasa
        public event Action<int> ev_modificare_valoare;

        int a;

        public CElement() {
            a = 0;

        }

        public int Vlement
        {
            get { return a; }
            set { 
                if(a != value )
                {
                    a = value;
                    if (ev_modificare_valoare != null) //daca ev este cuplat la o functie concreta, daca nu e null atunci execut metoda prin intermediul eventimentului
                        ev_modificare_valoare(value);
                }
                }
        }

        public int PElement => a * a;

    }
}
