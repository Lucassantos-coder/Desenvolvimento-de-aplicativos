using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA2_Devapp_Lucas_de_Sousa_Santos
{
    class Preparo
    {
        //Propriedades da classe de preparo
        public string Modopreparo { get; set; }

        public Preparo(string modopreparo)
        {
            Modopreparo = modopreparo;
        }

        public override string ToString()
        {
            return "Modo de preparo: " + Modopreparo;
        }
    }
}
