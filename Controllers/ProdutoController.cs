using System.Collections.Generic;
using Aula34MVC.Models;
using Aula34MVC.Views;

namespace Aula34MVC.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            produtoView.MostrarNoConsole(produtoModel.Ler() );
        }

        public void Filtrar(string _preco)
        {
            List<Produto> lista = produtoModel.Ler();
            lista = lista.FindAll(x => x.Preco == float.Parse( _preco ) );
            
            produtoView.MostrarNoConsole( lista );  
        }
    }
}