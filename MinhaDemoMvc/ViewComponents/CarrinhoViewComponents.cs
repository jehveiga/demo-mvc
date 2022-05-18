using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MinhaDemoMvc.ViewComponents
{
    [ViewComponent(Name = "Carrinho")] // Apelido para a View Component 
    public class CarrinhoViewComponents : ViewComponent
    {
        public int ItensCarrinho { get; set; }

        public CarrinhoViewComponents() // Construtor exemplo
        {
            ItensCarrinho = 3;
        }

        public async Task<IViewComponentResult> InvokeAsync() // Método para chamada da View Component
        {
            return View(ItensCarrinho); // Passando os dados para a View a ser chamada
        }
    }
}
