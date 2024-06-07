using GameForum.Data;
using Microsoft.AspNetCore.Mvc;

namespace GameForum.Controllers
{
    public class JogoController : Controller
    {
        private readonly DataContext _dataContext;
        public JogoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult EnviarJogo(Jogo NewJogo)
        {
            var findGame = _dataContext.Jogos.FirstOrDefault(x => 
                x.Title == NewJogo.Title && x.Developer == NewJogo.Developer);
            if (findGame != null) 
            {
                if (findGame.IsPublished)
                {
                    //TODO: Adicionar modal de informação
                    return RedirectToAction("PerfilPage", "User");
                }
            }

            _dataContext.Jogos.Add(NewJogo);
            _dataContext.SaveChanges();
            //TODO: Adicionar modal de informação
            return RedirectToAction("PerfilPage", "User");
        }

        public IActionResult BuscarTodosOsJogos() 
        {
            var AllGames = _dataContext.Jogos.ToList();
            
            return Ok(AllGames);
        }
        public IActionResult NaoPublicados() 
        {
            var noPub = _dataContext.Jogos.Where(x => !x.IsPublished).ToList();
            return Ok(noPub);
        }
        public IActionResult BuscarJogosPublicados()
        {
            var noPub = _dataContext.Jogos.Where(x => x.IsPublished).ToList();
            return Ok(noPub);
        }
        public IActionResult PublicarJogo(int jogoId)
        {
            var getJogo = _dataContext.Jogos.Find(jogoId);
            getJogo.IsPublished = true;

            return RedirectToAction("PerfilPage", "User");
        }
        public IActionResult DeletarJogo(int jogoId)
        {
            var getJogo = _dataContext.Jogos.Find(jogoId);

            _dataContext.Jogos.Remove(getJogo);
            _dataContext.SaveChanges();

            return RedirectToAction("PerfilPage", "User");
        }
    }
}
