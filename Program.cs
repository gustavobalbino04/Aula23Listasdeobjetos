using System;
//uso nessecario para chamar uma lista 
using  System.Collections.Generic;


namespace Aula23Listasdeobjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //como chamar uma lista 
           List<Produto> produtos = new List<Produto>();
           //forma com o metodo construtor 
           produtos.Add( new Produto(1,"Redmi AirDots",57.00f));
           produtos.Add( new Produto(2,"JBL Tune",149.99f));
           produtos.Add( new Produto(3,"Sony",59.99f));
           produtos.Add( new Produto(4,"JBL T110 ",45.00f));
           produtos.Add( new Produto(5,"Razer Kraken",629.99f));

           foreach (Produto p in produtos)
           {
               Console.WriteLine($"Nome:{p.Nome}, R$:{p.Preco}");
           }

           System.Console.WriteLine();

           //remover por ordem
           produtos.RemoveAt(4);
           //remove algo espeficico com o Lambda
           produtos.RemoveAll(x => x.Nome == "JBL Tune");


            foreach (Produto p in produtos)
           {
               Console.ForegroundColor = ConsoleColor.Red;     
               Console.WriteLine($"Nome:{p.Nome}, R$:{p.Preco}");
               Console.ResetColor();
           }

            System.Console.WriteLine();


            //localiza algo especifico
            Produto Sony = produtos.Find( p => p.Nome == "Sony");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( Sony.Preco );
            Console.ResetColor();

            System.Console.WriteLine();


           List<Cartao> cartoes = new List<Cartao>();
           cartoes.Add(new Cartao("Gustavo",234514,"Visa",12052040,624326312466f));
           cartoes.Add(new Cartao("Gustavo",456334,"MasterCard",12052050,6243263124667f));
           cartoes.Add(new Cartao("Gustavo",562342,"Visa",12052060,62432631246634128f));
           cartoes.Add(new Cartao("Gustavo",454678,"Hipercard",12052070,62432631246634129f));

            foreach (Cartao x in cartoes)
           {
               Console.ForegroundColor = ConsoleColor.Yellow;     
               Console.WriteLine($"Cartao:{x.Bandeira},Numero:{x.Numero}");
               Console.ResetColor();
           }

        }
    }
}
