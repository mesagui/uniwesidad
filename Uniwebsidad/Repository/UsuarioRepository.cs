using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Uniwebsidad.BaseDatos;
using Uniwebsidad.Models;

namespace Uniwebsidad.Repository
{
    public interface IUsuarioRepository
    {
        public Usuario UsuarioCurso(Curso Curso);
        public Usuario ObtenerUsuarioLogin(Claim claim);
        public Usuario EncontrarUsuario(String user, String password);
        public void AgregarUsuario(string Username, string Password, string Nombres);
    }
    public class UsuarioRepository : IUsuarioRepository
    {
        private CalidadContext _context;

        public UsuarioRepository(CalidadContext context)
        {
            _context = context;
        }

        public Usuario EncontrarUsuario(string user, string password)
        {
            var Usuario = _context._Usuarios.Where(o => o.Username == user && o.Password == password).FirstOrDefault();
            return Usuario;
        }

        public void AgregarUsuario(string Username, string Password, string Nombres)
        {
            Usuario nuevo = new Usuario();
            nuevo.Username = Username;
            nuevo.Password = Password;
            nuevo.Nombres = Nombres;
            _context._Usuarios.Add(nuevo);
            _context.SaveChanges();
        }

        public Usuario ObtenerUsuarioLogin(Claim claim)
        {
            var user = _context._Usuarios.FirstOrDefault(o => o.Username == claim.Value);
            return user;
        }

        public Usuario UsuarioCurso(Curso Curso)
        {
            var Usuario = _context._Usuarios.FirstOrDefault(o => o.Id == Curso.IdCreador);
            return Usuario;
        }
    }
}
