using BlueHorizon.Data;
using BlueHorizon.DTOs;
using BlueHorizon.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlueHorizon.Controllers
{
    public class AtualizacaoController : Controller
    {
        private readonly DataContext _dataContext;

        public AtualizacaoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        
        public IActionResult LerAtualizacao()
        {
            return View();
        }

        
        public IActionResult EnviarAtualizacao(AtualizacaoDTO request)
        {
            var atualizacao = new Atualizacao
            {
                Cidade = request.Cidade,
                Porto = request.Porto,
                pH = request.pH,
                OxigenioDissolvido = request.OxigenioDissolvido,
                Nitrato = request.Nitrato,
                Fosfato = request.Fosfato,
                Microplasticos = request.Microplasticos,
                Salinidade = request.Salinidade,
                DataAtualizacao = DateTime.Now
            };
            _dataContext.Atualizacoes.Add(atualizacao);
            _dataContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult EditarAtualizacao(int id, AtualizacaoDTO request)
        {
            var atualizacao = _dataContext.Atualizacoes.Find(id);
            if (atualizacao == null)
            {
                return NotFound();
            }

            atualizacao.Cidade = request.Cidade;
            atualizacao.Porto = request.Porto;
            atualizacao.pH = request.pH;
            atualizacao.OxigenioDissolvido = request.OxigenioDissolvido;
            atualizacao.Nitrato = request.Nitrato;
            atualizacao.Fosfato = request.Fosfato;
            atualizacao.Microplasticos = request.Microplasticos;
            atualizacao.Salinidade = request.Salinidade;

            _dataContext.Atualizacoes.Update(atualizacao);
            _dataContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult DeletarAtualizacao(int id)
        {
            var atualizacao = _dataContext.Atualizacoes.Find(id);
            if (atualizacao == null)
            {
                return NotFound();
            }

            _dataContext.Atualizacoes.Remove(atualizacao);
            _dataContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
