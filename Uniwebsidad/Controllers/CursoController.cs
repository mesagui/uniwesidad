using System;
using System.Collections.Generic;
using System.Linq;
using Uniwebsidad.BaseDatos;
using Uniwebsidad.Models;
using Microsoft.AspNetCore.Mvc;
using Uniwebsidad.Repository;
using Uniwebsidad.Service;

namespace Uniwebsidad.Controllers
{
    public class CursoController : Controller
    {

        private readonly IDetalleUsuarioCursoRepository _detalleUsuarioCurso;
        private readonly ICursoRepository _curso;
        private readonly ICategoriaRepository _categoria;
        private readonly IUsuarioRepository _usuario;
        private readonly IVideoRepository _video;
        private readonly ICookieAuthService _cookieAuthService;

        public CursoController(IDetalleUsuarioCursoRepository _detalleUsuarioCurso, ICursoRepository _curso,
            ICategoriaRepository _categoria,IUsuarioRepository _usuario,IVideoRepository _video,ICookieAuthService _cookieAuthService)
        {
            this._detalleUsuarioCurso = _detalleUsuarioCurso;
            this._curso = _curso;
            this._categoria = _categoria;
            this._usuario = _usuario;
            this._video = _video;
            this._cookieAuthService = _cookieAuthService;
        }

        public IActionResult Index(String busqueda = "")
        {
            Usuario user = LoggedUser();

            ViewBag.UsuarioId = user.Id;

            var MisCursos = _curso.MisCursos(user,busqueda);

            ViewBag.Categorias = _curso.CategoriaDeCursos(MisCursos);

            ViewBag.Cantidad = _curso.TotalDeCursos(MisCursos);

            ViewBag.MisCursos = MisCursos;
            
            return View();
        }


        
        public IActionResult CrearCursoInterface()
        {

            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;
            ViewBag.Categorias = _categoria.Categorias();

            //ViewBag.Validation = "Campos requeridos";

            return View();
        }


        
        public IActionResult CrearCursoForm(String Curso, int categoria)
        {
            
            if (Curso == null )
            {
                //ViewBag.Validation = "No se creo el curso";

                return RedirectToAction("CrearCursoInterface");
            }

            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;
            _curso.CrearCurso(Curso, categoria, user);
            //if (CursoCreado.IdCategoria == 0) HttpContext.Response.StatusCode = 500;

            HttpContext.Response.StatusCode = 200;

            return RedirectToAction("CursosCreadosPorUsuario", "Curso");
        }


        public IActionResult DetalleCurso(int Id)
        {
            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;

            var cursoDetalle = _detalleUsuarioCurso.DetalleCurso(Id);
            ViewBag.Curso = cursoDetalle;

            var Usuario = _usuario.UsuarioCurso(cursoDetalle);
            ViewBag.Usuario = Usuario;

            var videosCurso = _video.VideosDelCurso(Id);
            ViewBag.Videos = videosCurso;

            return View();
        }

        public IActionResult DetalleCursoLogout(int Id)
        {
            var cursoDetalle = _detalleUsuarioCurso.DetalleCurso(Id);
            ViewBag.Curso = cursoDetalle;

            var Usuario = _usuario.UsuarioCurso(cursoDetalle);
            ViewBag.Usuario = Usuario;

            var videosCurso = _video.VideosDelCurso(Id);
            ViewBag.Videos = videosCurso;
            return View();
        }

        public IActionResult TodosLosCursos(String busqueda = "")
        {
            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;

            var cursos = _curso.TodosLosCursos(busqueda);
            ViewBag.Cursos = cursos;

            var categorias = _curso.CategoriaDeCursos(cursos);
            ViewBag.Categorias = categorias;

            return View();
        }

        public IActionResult TodosLosCursosLogout(String busqueda = "")
        {
            var cursos = _curso.TodosLosCursos(busqueda);
            ViewBag.Cursos = cursos;

            var categorias = _curso.CategoriaDeCursos(cursos);
            ViewBag.Categorias = categorias;

            return View();
        }



        public IActionResult agregarCurso(int Id)
        {
            Usuario user = LoggedUser();
            if(user != null)
            {
                ViewBag.UsuarioId = user.Id;

                _curso.AgregarCurso(Id, user);

                return RedirectToAction("TodosLosCursos", "Curso");
            }
            return RedirectToAction("Login", "Auth");
        }


        public IActionResult desagregarCurso(int Id)
        {
            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;

            _curso.DesagregarCurso(Id,user);

            return RedirectToAction("Index", "Curso");
        }


        public IActionResult CursosCreadosPorUsuario()
        {
            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;
            var cursos = _curso.CursosCreados(user);

            ViewBag.Usuario = user.Nombres;
            ViewBag.CursosCreadosPorUsuario = cursos;
            ViewBag.Cantidad = cursos.Count();

            var categorias = _curso.CategoriaDeCursos(cursos);
            ViewBag.Categorias = categorias;

            return View();
        }


        public IActionResult AgregarVideoAlCurso(int Id)
        {
            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;
            ViewBag.IdVideo = Id;
            var cursos = _curso.CursosCreados(user);
            ViewBag.CursosCreadosPorUsuario = cursos;
            return View();
        }


        public IActionResult AgregarVideoAlCursoForm(int Idvideo,String video)
        {
            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;

            _video.AgregarVideo(Idvideo, video);

            return RedirectToAction("CursosCreadosPorUsuario", "Curso");
        }
        
        
        private Usuario LoggedUser()
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            var claim = _cookieAuthService.ObtenerClaim();
            var user = _usuario.ObtenerUsuarioLogin(claim);
            return user;
        }
        public IActionResult EditarCurso(int Id)
        {
            var curso =_curso.BuscarCursoId(Id);
            ViewBag.Curso = curso;
            
            ViewBag.Categorias = _categoria.Categorias();
            
            return View();
        }
        
        public IActionResult EditarCursoForm(int Id,string Nombre, int Categoria)
        {
            _curso.EditarCurso(Id,Nombre,Categoria);
            
         
            
            return RedirectToAction("CursosCreadosPorUsuario", "Curso");
        }

        
    }
}











