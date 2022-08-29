using ControleDeContatos.Models;
using ControleDeContatos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {//Precisamos configurar a injeção de dependencia da IController
            _contatoRepository = contatoRepository;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepository.BuscarTodos();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
            

        [HttpPost]
        public IActionResult Criar(ContatoModel contato) {
            //IActionResult = Varios tipos de retornos são possíveis em uma ação
            _contatoRepository.Adcionar(contato);
            return RedirectToAction("Index");
        }
    }
}
