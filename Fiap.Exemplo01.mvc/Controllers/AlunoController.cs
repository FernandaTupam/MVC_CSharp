using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiap.Exemplo01.mvc.Models;

namespace Fiap.Exemplo01.mvc.Controllers
{
    public class AlunoController : Controller
    {
        // Action para abrir o formulário
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        //Action para cadastrar as informações do formulário
        [HttpPost]
        public ActionResult Salvar(Aluno aluno)
        {
            ViewBag.nomeAluno = aluno.Nome;
            ViewBag.dataAluno = aluno.DtNascimento;
            ViewBag.salarioAluno = aluno.Salario;
            return View();
           
        }

    }
}