using LivrariaPHD.Models;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrariaController : ControllerBase
    {
        private readonly DBContext _context;

        public LivrariaController(DBContext context)
        {
            _context = context;

            _context.todoProducts.Add(new Produto { Id = "1", Nome = "Book1", Preco = 12.0, Categoria = "Ação", Quant = 1, Img = "img1" });
            _context.todoProducts.Add(new Produto { Id = "2", Nome = "Book2", Preco = 22.0, Categoria = "Ação", Quant = 3, Img = "img2" });
            _context.todoProducts.Add(new Produto { Id = "3", Nome = "Book3", Preco = 54.0, Categoria = "Ação", Quant = 5, Img = "img3" });
            _context.todoProducts.Add(new Produto { Id = "4", Nome = "Book4", Preco = 59.0, Categoria = "Ação", Quant = 5, Img = "img4" });
            _context.todoProducts.Add(new Produto { Id = "5", Nome = "Book5", Preco = 130.0, Categoria = "Ação", Quant = 2, Img = "img5" });

            _context.SaveChanges();
        }
    }
}
