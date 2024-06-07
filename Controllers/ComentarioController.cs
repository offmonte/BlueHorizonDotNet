using GameForum.Data;
using GameForum.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace GameForum.Controllers
{
    public class ComentarioController : Controller
    {
        private readonly DataContext _dataContext;

        public ComentarioController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult CriarComentario(int userId, int avaliationId, int jogoId, ComentarioDTO request)
        {
            var comentario = new Comentario
            {
                UseId = userId,
                AvaliationId = avaliationId,
                JogoId = jogoId,
                TxtComment = request.TxtComment,
                CommentDate = DateTime.Now,
            };
            _dataContext.Comentarios.Add(comentario);
            _dataContext.SaveChanges();

            return RedirectToAction("DetalhesAvaliacao", "Avaliacao", new { id = avaliationId });
        }

        public IActionResult EditarComentario(int commentId, ComentarioDTO request)
        {
            var comentario = _dataContext.Comentarios.Find(commentId);
            if (comentario == null)
            {
                return NotFound();
            }

            comentario.TxtComment = request.TxtComment;
            _dataContext.Comentarios.Update(comentario);
            _dataContext.SaveChanges();

            return RedirectToAction("DetalhesAvaliacao", "Avaliacao", new { id = comentario.AvaliationId });
        }

        public IActionResult DeletarComentario(int commentId)
        {
            var comentario = _dataContext.Comentarios.Find(commentId);
            if (comentario == null)
            {
                return NotFound();
            }

            _dataContext.Comentarios.Remove(comentario);
            _dataContext.SaveChanges();

            return RedirectToAction("DetalhesAvaliacao", "Avaliacao", new { id = comentario.AvaliationId });
        }
    }
}
