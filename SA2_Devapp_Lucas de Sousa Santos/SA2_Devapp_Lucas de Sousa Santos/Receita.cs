using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA2_Devapp_Lucas_de_Sousa_Santos
{
    class Receita
    {
        //Propriedades da clase receita
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Tempopreparo { get; set; }
        public int Dificuldade { get; set; }
        public int Pessoas { get; set; }
        public int Categoria { get; set; }
        public double Valor { get; set; }
        public int Qtdingredientes { get; set; }
        

        public Receita (int id, string nome, double tempopreparo, int dificuldade, int pessoas, int categoria, double valor, int qtdingredientes)
        {
            Id = id;
            Nome = nome;
            Tempopreparo = tempopreparo;
            Dificuldade = dificuldade;
            Pessoas = pessoas;
            Categoria = categoria;
            Valor = valor;
            Qtdingredientes = qtdingredientes;            
        }

        public override string ToString()
        {
            return "Número da receita: "+ Id +
                "\nNome: " + Nome +
                "\nTempo de preparo: " + Tempopreparo +
                "\nNível de dificuldade: " + Dificuldade +
                "\nNúmero de pessoas que a receita serve: " + Pessoas +
                "\nCategoria: " + Categoria +
                 "\nValor Estimado da receita: " + Valor+
                "\nQuantidade de ingredientes: " + Qtdingredientes;
        }
    }
}

