using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA2_Devapp_Lucas_de_Sousa_Santos
{
    class Program
    {
        static int Exibemenu()
        {   
            //Menu principal         
            Console.Clear();
            Console.WriteLine("Receitas de culinária");
            Console.WriteLine("Menu principal");
            Console.WriteLine("|----------------------------------|");
            Console.WriteLine("|1-Cadastrar receitas              |");
            Console.WriteLine("|2-Listar receitas cadastradas     |");
            Console.WriteLine("|3-Editar receita                  |");
            Console.WriteLine("|4-Eliminar receita                |");
            Console.WriteLine("|5-Lista atualizada                |");
            Console.WriteLine("|6-sair                            |");
            Console.WriteLine("|----------------------------------|");
            Console.Write("Escolha a opção desejada no menu acima: ");//Escolha da opção desejada
            int Opcao = int.Parse(Console.ReadLine());
            return Opcao;
        }
        static void Main(string[] args)
        {           
            //Instanciação das listas 
            List<Receita> receita = new List<Receita>();
            List<Ingredientes> ingredientes = new List<Ingredientes>();
            List<Preparo> preparo = new List<Preparo>();
            int Opcao = 0;

            //Laço de repetição para as opções do menu
            while(Opcao != 6)
            {
                Opcao = Exibemenu();
                Console.Clear();
                //Cadastro de receitas
                if (Opcao == 1)
                {
                    Console.WriteLine("Cadastro de receitas");
                    Console.Write("Insira a quantidade de receitas que deseja cadastrar: ");
                    int N = int.Parse(Console.ReadLine());
                    for (int i = 0; i < N; i++)
                    {
                        int id = i;
                        Console.Write("Nome da receita: ");
                        string nome = Console.ReadLine();
                        Console.Write("Tempo de preparo em minutos: ");
                        double tempopreparo = double.Parse(Console.ReadLine());
                        Console.Write("Grau de dificuldade de 0 10 (1 = Muito fácil 10 = Muito difícil): ");
                        int dificuldade = int.Parse(Console.ReadLine());
                        Console.Write("Número de pessoas que a receita serve: ");
                        int pessoas = int.Parse(Console.ReadLine());
                        Console.Write("Categoria (1=entrada  2=prato principal  3=sobremesa): ");
                        int categoria = int.Parse(Console.ReadLine());
                        Console.Write("Valor estimado da receita: ");
                        double valor = double.Parse(Console.ReadLine());
                        Console.Write("Quantidade de ingredientes: ");
                        int qtdingredientes = int.Parse(Console.ReadLine());
                        receita.Add(new Receita(id, nome, tempopreparo, dificuldade, pessoas, categoria, valor, qtdingredientes));
                        for(int j = 0; j < qtdingredientes; j++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingredientes");
                            Console.Write("Nome do ingrediente " + (j + 1) + ": ");
                            string nomeing = Console.ReadLine();                            
                            Console.Write("Medida necessária: ");
                            string medida = Console.ReadLine();

                            ingredientes.Add(new Ingredientes(nomeing,medida));                                                       
                        }
                        for(int k = 0; k < 1; k++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Modo de preparo");
                            Console.Write("Modo de preparo: ");
                            string modopreparo = Console.ReadLine();
                            preparo.Add(new Preparo(modopreparo));
                            Console.Clear();
                        }                       
                        Console.Clear();
                    }
                }

                //Listagem das receitas cadastradas
                if (Opcao == 2)
                {
                    Console.Clear();                
                    Console.WriteLine("|----------------------------------|");
                    Console.WriteLine("|1-Alfabética                      |");
                    Console.WriteLine("|2-Dificuldade                     |");
                    Console.WriteLine("|3-Categoria                       |");
                    Console.WriteLine("|4-Tempo de preparo                |");
                    Console.WriteLine("|5-Valor estimado                  |");
                    Console.WriteLine("|----------------------------------|");
                    Console.Write("Por qual ordem deseja que as receitas sejam listadas?");//Escolha da orcem desejada
                    int Escolhaordem = int.Parse(Console.ReadLine());
                    Console.Clear();

                    //Listagem por ordem alfabética
                    if (Escolhaordem == 1)
                    {
                        List<Receita> receitaalfabeto = (from A in receita orderby A.Nome ascending select A).ToList();
                        Console.WriteLine("Receitas por ordem alfabética");
                        foreach (Receita a in receitaalfabeto)
                        {
                            Console.WriteLine("");                        
                            Console.WriteLine(a);
                            foreach (Ingredientes I in ingredientes)
                            {
                                Console.WriteLine(I);
                            }
                            foreach (Preparo p in preparo)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        Console.ReadKey();
                    }

                    //Listagem por ordem de dificuldade
                    if (Escolhaordem == 2)
                    {
                        List<Receita> receitadificuldade = (from D in receita orderby D.Dificuldade ascending select D).ToList();
                        Console.WriteLine("Receitas por ordem de dificuldade");
                        foreach (Receita d in receitadificuldade)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(d);
                            foreach (Ingredientes I in ingredientes)
                            {
                                Console.WriteLine(I);
                            }
                            foreach (Preparo p in preparo)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        Console.ReadKey();
                    }

                    //Listagem por ordem de categoria
                    if (Escolhaordem == 3)
                    {

                        List<Receita> receitacategoria = (from C in receita orderby C.Categoria ascending select C).ToList();
                        Console.WriteLine("Receitas por ordem de categoria");
                        foreach (Receita c in receitacategoria)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(c);
                            foreach (Ingredientes I in ingredientes)
                            {
                                Console.WriteLine(I);
                            }
                            foreach (Preparo p in preparo)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        Console.ReadKey();
                    }

                    //Listagem por ordem de tempo de preparo
                    if (Escolhaordem == 4)
                    {
                        List<Receita> receitapreparo = (from P in receita orderby P.Tempopreparo ascending select P).ToList();
                        Console.WriteLine("Receitas por ordem de tempo de preparo");
                        foreach (Receita pr in receitapreparo)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(pr);
                            foreach (Ingredientes I in ingredientes)
                            {
                                Console.WriteLine(I);
                            }
                            foreach (Preparo p in preparo)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        Console.ReadKey();
                    }

                    //Listagem por ordem de valor
                    if (Escolhaordem == 5)
                    {
                        List<Receita> receitavalor = (from V in receita orderby V.Valor ascending select V).ToList();
                        Console.WriteLine("Receitas por ordem de valor estimado");
                        foreach (Receita v in receitavalor)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(v);
                            foreach (Ingredientes I in ingredientes)
                            {
                                Console.WriteLine(I);
                            }
                            foreach (Preparo p in preparo)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        Console.ReadKey();
                    }
                }

                //Edição dos dados da receita desejada
                if (Opcao == 3)
                {
                    Console.Clear();                  
                    Console.WriteLine("Edição de receitas");
                    Console.WriteLine("|----------------------------------|");
                    Console.WriteLine("|1-Nome                            |");
                    Console.WriteLine("|2-Tempo de preparo                |");
                    Console.WriteLine("|3-Nível de dificuldade            |");
                    Console.WriteLine("|4-Número de pessoas que serve     |");
                    Console.WriteLine("|5-Categoria                       |");
                    Console.WriteLine("|6-Valor estimado                  |");
                    Console.WriteLine("|7-Quantidade de ingredientes      |");
                    Console.WriteLine("|----------------------------------|");
                    Console.Write("Qual característica deseja alterar? ");
                    int Escolhaalteracao = int.Parse(Console.ReadLine());

                    //Alteração de nome
                    if (Escolhaalteracao == 1)
                    {
                        Console.Clear();
                        List<Receita> receitaordenada = (from O in receita orderby O.Id ascending select O).ToList();
                        Console.WriteLine("Alterar nome");
                        Console.WriteLine("");
                        Console.WriteLine("Receitas cadastradas");
                        foreach (Receita a in receitaordenada)
                        {
                            Console.WriteLine(a.Nome);
                        }
                        Console.WriteLine("");
                        Console.Write("Escolha qual nome deseja alterar:");
                        string Alternome = Console.ReadLine();
                        Console.Write("Para qual nome deseja alterar? ");
                        string Novonome = Console.ReadLine();

                        foreach (Receita a in receitaordenada)
                        {
                            if (Alternome == a.Nome)
                            {
                                a.Nome = Novonome;
                            }
                        }                        
                    }

                    //Alteração do tempo de preparo
                    if (Escolhaalteracao == 2)
                    {
                        Console.Clear();
                        List<Receita> receitaordenada = (from O in receita orderby O.Id ascending select O).ToList();
                        Console.WriteLine("Alterar tempo de preparo");
                        Console.WriteLine("");
                        Console.WriteLine("Receitas cadastradas");
                        foreach (Receita a in receitaordenada)
                        {
                            Console.WriteLine(a.Tempopreparo);
                        }
                        Console.WriteLine("");
                        Console.Write("Escolha qual tempo de preparo deseja alterar:");
                        double Alterartempopreparo = double.Parse(Console.ReadLine());
                        Console.Write("Para qual tempo será alterado deseja alterar? ");
                        double Novotempopreparo = int.Parse(Console.ReadLine());

                        foreach (Receita a in receitaordenada)
                        {
                            if (Alterartempopreparo == a.Tempopreparo)
                            {
                                a.Tempopreparo = Novotempopreparo;
                            }
                        }
                    }

                    //Alteração do nível de dificuldade
                    if (Escolhaalteracao == 3)
                    {
                        Console.Clear();
                        List<Receita> receitaordenada = (from O in receita orderby O.Id ascending select O).ToList();
                        Console.WriteLine("Alterar nível de dificuldade");
                        Console.WriteLine("");
                        Console.WriteLine("Receitas cadastradas");
                        foreach (Receita a in receitaordenada)
                        {
                            Console.WriteLine(a.Dificuldade);
                        }
                        Console.WriteLine("");
                        Console.Write("Escolha qual nível de dificuldade deseja alterar:");
                        int Alterardificuldade = int.Parse(Console.ReadLine());
                        Console.Write("Para qual id deseja alterar? ");
                        int Novadificuldade = int.Parse(Console.ReadLine());

                        foreach (Receita a in receitaordenada)
                        {
                            if (Alterardificuldade == a.Dificuldade)
                            {
                                a.Dificuldade = Novadificuldade;
                            }
                        }                       
                    }

                    //Alteração do número de pessoas
                    if (Escolhaalteracao == 4)
                    {
                        Console.Clear();
                        List<Receita> receitaordenada = (from O in receita orderby O.Id ascending select O).ToList();
                        Console.WriteLine("Alterar número de pessoas que a receita serve");
                        Console.WriteLine("");
                        Console.WriteLine("Receitas cadastradas");
                        foreach (Receita a in receitaordenada)
                        {
                            Console.WriteLine(a.Pessoas);
                        }
                        Console.WriteLine("");
                        Console.Write("Escolha qual número de pessoas deseja alterar:");
                        int Alterarpessoas = int.Parse(Console.ReadLine());
                        Console.Write("Para qual número de pessoas deseja alterar? ");
                        int Novopessoas = int.Parse(Console.ReadLine());

                        foreach (Receita a in receitaordenada)
                        {
                            if (Alterarpessoas == a.Pessoas)
                            {
                                a.Pessoas = Novopessoas;
                            }
                        }                        
                    }

                    //Alteração de categoria
                    if (Escolhaalteracao == 5)
                    {
                        Console.Clear();
                        List<Receita> receitaordenada = (from O in receita orderby O.Id ascending select O).ToList();
                        Console.WriteLine("Alterar categoria");
                        Console.WriteLine("");
                        Console.WriteLine("Receitas cadastradas");
                        foreach (Receita a in receitaordenada)
                        {
                            Console.WriteLine(a.Categoria);
                        }
                        Console.WriteLine("");
                        Console.Write("Escolha qual categoria deseja alterar:");
                        int Alterarcategoria = int.Parse(Console.ReadLine());
                        Console.Write("Para qual id deseja alterar? ");
                        int Novacategoria = int.Parse(Console.ReadLine());

                        foreach (Receita a in receitaordenada)
                        {
                            if (Alterarcategoria == a.Categoria)
                            {
                                a.Categoria = Novacategoria;
                            }
                        }                        
                    }

                    //Alteração do valor estimado
                    if (Escolhaalteracao == 6)
                    {
                        Console.Clear();
                        List<Receita> receitaordenada = (from O in receita orderby O.Id ascending select O).ToList();
                        Console.WriteLine("Alterar Valor estimado");
                        Console.WriteLine("");
                        Console.WriteLine("Receitas cadastradas");
                        foreach (Receita a in receitaordenada)
                        {
                            Console.WriteLine(a.Valor);
                        }
                        Console.WriteLine("");
                        Console.Write("Escolha qual valor deseja alterar:");
                        int Alterarvalor = int.Parse(Console.ReadLine());
                        Console.Write("Para qual id deseja alterar? ");
                        int Novovalor = int.Parse(Console.ReadLine());

                        foreach (Receita a in receitaordenada)
                        {
                            if (Alterarvalor == a.Valor)
                            {
                                a.Valor = Novovalor;
                            }
                        }                       
                    }

                    //Alteração da quantidade de ingredientes
                    if (Escolhaalteracao == 7)
                    {
                        Console.Clear();
                        List<Receita> receitaordenada = (from O in receita orderby O.Id ascending select O).ToList();
                        Console.WriteLine("Alterar quantidade de ingedientes");
                        Console.WriteLine("");
                        Console.WriteLine("Receitas cadastradas");
                        foreach (Receita a in receitaordenada)
                        {
                            Console.WriteLine(a.Qtdingredientes);
                        }
                        Console.WriteLine("");
                        Console.Write("Escolha qual Quantidade deseja alterar:");
                        int Alterarqtd = int.Parse(Console.ReadLine());
                        Console.Write("Para qual Quantidade deseja alterar? ");
                        int Novaqtd = int.Parse(Console.ReadLine());

                        foreach (Receita a in receitaordenada)
                        {
                            if (Alterarqtd == a.Qtdingredientes)
                            {
                                a.Qtdingredientes = Novaqtd;
                            }
                        }
                        Console.ReadKey();
                    }                   
                }

                //Remoção da receita desejada
                if (Opcao == 4)
                {
                    List<Receita> receitaordenada = (from O in receita orderby O.Id ascending select O).ToList();
                    Console.WriteLine("Remoção de receitas");
                    Console.WriteLine("");
                    foreach(Receita a in receitaordenada)
                    {
                        Console.WriteLine(a.Id+ ": " +a.Nome);
                    }
                    Console.Write("Escreva o número da receita que deseja remover: ");
                    int Removerreceita = int.Parse(Console.ReadLine());


                    receitaordenada.RemoveAt(Removerreceita);

                    receita = receitaordenada;

                    foreach (Receita a in receitaordenada)
                    {
                        Console.WriteLine("Receita excluída");
                        Console.WriteLine("");
                        Console.WriteLine(a);
                    }
                    Console.ReadKey();
                }

                //Listegem das receitas após a edição
                if (Opcao == 5)
                {
                    List<Receita> receitaordenada = (from O in receita orderby O.Id ascending select O).ToList();
                    Console.WriteLine("Receitas atualizadas");

                    foreach (Receita a in receitaordenada)
                    {
                        Console.WriteLine(a);
                    }
                    
                }
            }               
        }                
    }
}
    

