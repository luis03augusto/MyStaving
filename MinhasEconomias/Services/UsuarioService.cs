using MinhasEconomias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasEconomias.Services
{
    public class UsuarioService
    {
        private readonly EnonomiasContext _context = new EnonomiasContext();

        public IList<Usuario> ListarUsuarios()
        {
            return _context.Usuarios.ToList();
        } 

        public void SalvarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public Usuario BuscarById(int IdUsuario)
        {
            return _context.Usuarios.Find(IdUsuario);
        }
        public void UpdateUsuario(Usuario usuario)
        {
            Usuario usr = BuscarById(usuario.Id);
            usr.Nome = usuario.Nome;
            usr.Email = usuario.Email;
            usr.CPF = usuario.CPF;
            _context.SaveChanges();
        }
        public void DeleteUsuario(int IdUsuario)
        {
            Usuario usr = BuscarById(IdUsuario);
            _context.Usuarios.Remove(usr);
            _context.SaveChanges();
        }

    }
}
