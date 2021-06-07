using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uniwebsidad.BaseDatos;
using Uniwebsidad.Models;

namespace Uniwebsidad.Repository
{
    public interface ICursoRepository
    {
        public List<int> IndiceDeCursos(Usuario user);
        public List<Curso> MisCursos(Usuario user,String busqueda);
        public Dictionary<int, String> CategoriaDeCursos(List<Curso> MisCursos);
        public void CrearCurso(String Curso, int Categoria, Usuario user);
        public List<Curso> TodosLosCursos(String busqueda);
        public void AgregarCurso(int Id, Usuario user);
        public void DesagregarCurso(int Id, Usuario user);
        public List<Curso> CursosCreados(Usuario user);
        public int TotalDeCursos(List<Curso> Cursos);
        public void EditarCurso(int Id,string Nombre,int Categoria);
        public Curso BuscarCursoId(int Id);
    }

    public class CursoRepository : ICursoRepository
    {
        private CalidadContext _context;

        public CursoRepository(CalidadContext context)
        {
            _context = context;
        }

        public void AgregarCurso(int Id, Usuario user)
        {
            DetalleUsuarioCurso nuevoDetalleUsuarioCurso = new DetalleUsuarioCurso();
            nuevoDetalleUsuarioCurso.Estado = true;
            nuevoDetalleUsuarioCurso.IdCurso = Id;
            nuevoDetalleUsuarioCurso.IdUsuario = user.Id;

            _context._DetalleUsuarioCursos.Add(nuevoDetalleUsuarioCurso);
            _context.SaveChanges();
            Video nuevo = new Video();
            nuevo.Link = "";
            nuevo.IdCurso = Id;
            _context._Videos.Add(nuevo);
            _context.SaveChanges();
        }

        public Dictionary<int, string> CategoriaDeCursos(List<Curso> MisCursos)
        {
            Dictionary<int, String> categorias = new Dictionary<int, string>();
            var categoriasa = _context._Categorias.ToList();
            foreach (var item in MisCursos)
            {
                categorias.Add(item.Id, _context._Categorias.Where(o => o.Id == item.IdCategoria).FirstOrDefault().Nombre);
            }
            return categorias;
        }

        public void CrearCurso(string Curso, int categoria, Usuario user)
        {
            Curso CursoCreado = new Curso();
            CursoCreado.FechaCreacion = DateTime.Now;
            CursoCreado.IdCategoria = categoria;
            CursoCreado.IdCreador = user.Id;
            CursoCreado.Nombre = Curso;
            _context._Cursos.Add(CursoCreado);
            _context.SaveChanges();
        }

        public List<Curso> CursosCreados(Usuario user)
        {
            var cursos = _context._Cursos.Where(o => o.IdCreador == user.Id).ToList();
            return cursos;
        }

        public void DesagregarCurso(int Id, Usuario user)
        {
            var cursoQuitar = _context._DetalleUsuarioCursos
                .FirstOrDefault(o => o.IdCurso == Id && o.IdUsuario == user.Id);

            _context._DetalleUsuarioCursos.Remove(cursoQuitar);
            _context.SaveChanges();
        }

        public List<int> IndiceDeCursos(Usuario user)
        {
            var indices = _context._DetalleUsuarioCursos.Where(o => o.IdUsuario == user.Id).ToList()
                .Select(o => o.IdCurso).ToList();

            return indices;
        }

        public List<Curso> MisCursos(Usuario user,String busqueda)
        {
            var indicesDeMisCursos = IndiceDeCursos(user);
            List<Curso> MisCursos = new List<Curso>();
            var cursos = _context._Cursos.ToList();
            for (int i = 0; i < cursos.Count; i++)
            {
                if (indicesDeMisCursos.Contains(cursos[i].Id))
                {
                    MisCursos.Add(cursos[i]);
                }
            }
            
            if (busqueda==""||busqueda == null)
            {
                return MisCursos; 
            }

       
            return MisCursos.Where(o=>o.Nombre.ToLower().Contains(busqueda.ToLower())).ToList();
        }

        public List<Curso> TodosLosCursos(String busqueda)
        {
            if (busqueda==""||busqueda == null)
            {
                return _context._Cursos.ToList();
            }
            var Cursos = _context._Cursos.ToList().Where(o=>o.Nombre.ToLower().Contains(busqueda.ToLower())).ToList();
            return Cursos;
        }

        public int TotalDeCursos(List<Curso> Cursos)
        {
            var TotalDeCursos = Cursos.Count();
            return TotalDeCursos;
        }

        public void EditarCurso(int Id,string Nombre,int Categoria)
        {
            var curso = _context._Cursos.Where(o => o.Id == Id).FirstOrDefault();
            curso.Id =Id;
            curso.Nombre =Nombre;
            curso.IdCategoria =Categoria;
            _context.SaveChanges();

        }
        
        public Curso BuscarCursoId(int Id)
        {
            var curso = _context._Cursos.Where(o => o.Id == Id).FirstOrDefault();
            return curso;
        }
    }
}
