using System.Collections.Generic;
using Aula34MVC.Models;

namespace Aula34MVC.Views
{
    public class ProdutoView
    {
        
        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach (Produto item in lista)
            {
                System.Console.WriteLine($" R$ {item.Preco} - {item.Nome}" );
            }
        }

    }
}