﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    


    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            Usuario user = new Usuario
            {
                ID = 1,
                PrimeiroNome = "Biru",
                UltimoNome = "Leibe",
                Login = "Biruleibe",
                Email = "biruleibe@gmail.com",
                DataNascimento = DateTime.Now,
                Telefone = "(14)98812-5477"
            };

            return RedirectToAction("Envio", user);            
            
        }

        public IActionResult Envio(Usuario user)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            return View(user);
        }








        [Route("adicao/{valor1:double}/{valor2:double}")]
        public IActionResult Adicao(double valor1, double valor2)
        {
            double soma = valor1 + valor2;
            return Content(Convert.ToString(soma));
        }

        [Route("subtracao/{valor1:double}/{valor2:double}")]
        public IActionResult Subtracao(double valor1, double valor2)
        {
            double subtracao = valor1 - valor2;
            return Content(Convert.ToString(subtracao));
        }

        [Route("multiplicacao/{valor1:double}/{valor2:double}")]
        public IActionResult Multiplicacao(double valor1, double valor2)
        {
            double multiplicacao = valor1 * valor2;
            return Content(Convert.ToString(multiplicacao));
        }

        [Route("divisao/{valor1:double}/{valor2:double}")]
        public IActionResult Divisao(double valor1, double valor2)
        {
            double divisao = valor1 / valor2;
            return Content(Convert.ToString(divisao));
        }



        [Route("privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



       
    }
}
