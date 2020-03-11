using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AlunoController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        public AlunoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Aluno aluno = new Aluno()
            {
                ID = 1,
                Nome = "Guilherme",
                Sobrenome = "Billar",
                RA = "000001",
                Curso = "ASP.NET Core",
                Status = "Ativo",
                DataInicio = DateTime.Now,
                DataTermino = DateTime.Now.AddDays(40),
                Email = "guilherme.billar@email.com",
                Telefone = "9987654321",
                Escola = "Matriz",
                Endereço = "Rua da Connect, 001",
                CPF = "12345678901"
            };

            return RedirectToAction("Cadastro", aluno);
        }

        public IActionResult Cadastro(Aluno aluno) 
        {
            if (!ModelState.IsValid) {
                return BadRequest();
            }
            return View();
        }
    }
}