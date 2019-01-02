using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhasEconomias.Models;
using MinhasEconomias.Services;

namespace MinhasEconomias.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly UsuarioService _service = new UsuarioService();

        public IActionResult Usuario()
        {
            IList<Usuario> usr = _service.ListarUsuarios();
            return View(usr);
        }
        public IActionResult AddUsuario(Usuario usuario)
        {
            _service.SalvarUsuario(usuario);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult FormUsuario()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetById(int idUsr)
        {
            var usr =_service.BuscarById(idUsr);
            return Json(usr);
        }

        [HttpPost]
        public IActionResult DeleteUsr(int idUsr)
        {
            _service.DeleteUsuario(idUsr);
            return RedirectToAction("Usuario");
        }
    }
}