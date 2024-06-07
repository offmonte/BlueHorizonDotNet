using GameForum.Data;
using GameForum.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace GameForum.Controllers
{
    public class AvaliacaoController : Controller
    {
        private readonly DataContext _dataContext;
        public AvaliacaoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult CriarAvaliacao(int jogoId, int userId, AvaliacaoDTO request)
        {
            var avaliacao = new Avaliacao
            {
                UserId = userId,
                JogoId = jogoId,
                Cassification = request.Cassification,
                TxtAvaliation = request.TxtAvaliation,
                PostDate = DateTime.Now,
            };
            _dataContext.Avaliacoes.Add(avaliacao);
            _dataContext.SaveChanges();

            return RedirectToAction("PerfilPage", "User");
        }
        public IActionResult EditarAvaliacao(int avalId, AvaliacaoDTO request)
        {
            var findAval = _dataContext.Avaliacoes.Find(avalId);

            findAval.Cassification = request.Cassification;
            findAval.TxtAvaliation = request.TxtAvaliation;
               
            _dataContext.Avaliacoes.Update(findAval);
            _dataContext.SaveChanges();

            return RedirectToAction("PerfilPage", "User");
        }
        public IActionResult Delete(int id)
        {
            var findAval = _dataContext.Avaliacoes.Find(id);

            _dataContext.Avaliacoes.Remove(findAval);
            _dataContext.SaveChanges();

            return RedirectToAction("PerfilPage", "User");
        }
    }
}
