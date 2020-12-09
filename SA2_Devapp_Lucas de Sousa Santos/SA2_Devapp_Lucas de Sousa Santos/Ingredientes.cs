using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA2_Devapp_Lucas_de_Sousa_Santos
{
    class Ingredientes
    {
        //Propriedades da classe de ingredientes
        public string Nomeing { get; set; }
        public string Medida { get; set; }
        

        public Ingredientes(string nomeing, string medida)
        {
            Nomeing = nomeing;
            Medida = medida;
                      
        }
        public override string ToString()
        {
            return "Nome do ingrediente: " + Nomeing +
                "\nMedida necessária do ingrediente: " + Medida
                ;
        }
    }
}
