using BootCamp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BootCamp.Data;


namespace BootCamp.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly BootCampContext _context;

        public ProdutoController(BootCampContext context)
        {
            _context = context;
        }

        // Ação para listar todos os produtos
        public IActionResult Index()
        {
            var produtos = _context.GoldenPenProdutos.ToList();
            return View(produtos);
        }

        // Ação para exibir o formulário de adição de produto
        public IActionResult Adicionar()
        {
            return View();
        }

        // Ação para processar o formulário de adição de produto
        [HttpPost]
        public IActionResult Adicionar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.GoldenPenProdutos.Add(produto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // Ação para exibir o formulário de edição de produto
        public IActionResult Editar(int id)
        {
            var produto = _context.GoldenPenProdutos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        // Ação para processar o formulário de edição de produto
        [HttpPost]
        public IActionResult Editar(int id, Produto produto)
        {
            if (id != produto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produto);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // Ação para exibir o formulário de exclusão de produto
        public IActionResult Excluir(int id)
        {
            var produto = _context.GoldenPenProdutos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        // Ação para processar a exclusão de produto
        [HttpPost]
        public IActionResult ConfirmarExclusao(int id)
        {
            Console.WriteLine("ID Recebido: " + id);

            var produto = _context.GoldenPenProdutos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }

            _context.GoldenPenProdutos.Remove(produto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        private bool ProdutoExists(int id)
        {
            return _context.GoldenPenProdutos.Any(e => e.ID == id);
        }
    }

}