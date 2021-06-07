using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Uniwebsidad.BaseDatos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Uniwebsidad.Repository;
using Uniwebsidad.Service;

namespace Uniwebsidad.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUsuarioRepository _usuario;
        private readonly ICookieAuthService _cookieAuthService;


        public AuthController(IUsuarioRepository _usuario, ICookieAuthService _cookieAuthService)
        {

            this._usuario = _usuario;
            this._cookieAuthService = _cookieAuthService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var usuario = _usuario.EncontrarUsuario(username, password);
            if (usuario != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                _cookieAuthService.SetHttpContext(HttpContext);
                _cookieAuthService.Login(claimsPrincipal);


                return RedirectToAction("TodosLosCursos", "Curso");
            }

            ViewBag.Validation = "Usuario y/o contraseña incorrecta";
            return View();
        }

        //   [HttpGet]
        //   public IActionResult Registrarse()
        //   {
        //       return View(new Usuario());
        //   }
        /*  
             [HttpPost]
             public IActionResult Registrarse(Usuario usuario)
             {
     
     
            if (ModelState.IsValid)
                 {
                     _usser.AgregarUsuario(usuario);
     
                     _listaReproduccion.CrewarFavoritoPorDefecto(usuario);
     
                     return RedirectToAction("Index", "Home");
                 }
     
                 return RedirectToAction("Index", "Home");
             }*/

        public ActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("TodosLosCursosLogout","Curso");
        }

        public IActionResult Registrar()
        {
            return View();
        }
        public IActionResult RegisterC(string Username,string Password, string Nombres)
        {
            _usuario.AgregarUsuario(Username,Password,Nombres);
            return RedirectToAction("Login","Auth");
        }
    }
}