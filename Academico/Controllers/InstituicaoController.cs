using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> Instituicoes = new List<Isti>
        new InstituicaoController()
        {
            InstituicaoID = 1,
            Nome = "Hogwarts",
            Endereco ="Escola"
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}