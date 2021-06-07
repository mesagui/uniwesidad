using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniwebsidad.Controllers;
using Uniwebsidad.Models;
using Uniwebsidad.Repository;
using Uniwebsidad.Service;

namespace UniwebsidadTests.ControladoresTest
{
    class CursoControllerTests
    {

        [Test]
        public void UsuarioIngresaAlIndex()
        {
            List<Curso> MisCursos = new List<Curso>();
            var userMock = new Mock<IUsuarioRepository>();
            var cursoMock = new Mock<ICursoRepository>();
            var cookMock = new Mock<ICookieAuthService>();

            userMock.Setup(o => o.ObtenerUsuarioLogin(null)).Returns(new Usuario() { });
            
            cursoMock.Setup(o => o.MisCursos(new Usuario(),null));
            cursoMock.Setup(o => o.CategoriaDeCursos(MisCursos));
            cursoMock.Setup(o => o.TotalDeCursos(MisCursos));

            var configCurso = new CursoController(null, cursoMock.Object, null, userMock.Object, null, cookMock.Object);
            var guardarCom = configCurso.Index("");

            Assert.IsInstanceOf<ViewResult>(guardarCom);
        }


        [Test]
        public void UsuarioCreaUncurso()
        {

            var userMock = new Mock<IUsuarioRepository>();
            var cursoMock = new Mock<ICursoRepository>();
            var cookMock = new Mock<ICookieAuthService>();

            userMock.Setup(o => o.ObtenerUsuarioLogin(null)).Returns(new Usuario() { });

            cursoMock.Setup(o => o.CrearCurso("Calculo", 2, new Usuario()));

            var configCurso = new CursoController(null, cursoMock.Object, null, userMock.Object, null, cookMock.Object);

            var guardarCom = configCurso.CrearCursoForm("Calculo", 2);

            Assert.IsInstanceOf<RedirectToActionResult>(guardarCom);
        }


        [Test]
        public void UsuarioAgregaUnCursoASuLista()
        {

            Usuario Mario = new();
            Mario.Id = 1;
            Mario.Nombres = "mario";
            Mario.Password = "123";
            Mario.Username = "marioAdmin";

            var userMock = new Mock<IUsuarioRepository>();
            var cursoMock = new Mock<ICursoRepository>();
            var cookMock = new Mock<ICookieAuthService>();

            userMock.Setup(o => o.ObtenerUsuarioLogin(null)).Returns(Mario);

            cursoMock.Setup(o => o.AgregarCurso(2, Mario));

            var configCurso = new CursoController(null, cursoMock.Object, null, userMock.Object, null, cookMock.Object);

            var guardarCom = configCurso.agregarCurso(1);

            Assert.IsInstanceOf<RedirectToActionResult>(guardarCom);
        }


        [Test]
        public void UsuarioAgregaVideoASuCursoCreado()
        {
            var userMock = new Mock<IUsuarioRepository>();
            var VideoMoq = new Mock<IVideoRepository>();
            var cookMock = new Mock<ICookieAuthService>();

            userMock.Setup(o => o.ObtenerUsuarioLogin(null)).Returns(new Usuario() { });
            
            VideoMoq.Setup(o => o.AgregarVideo(2, "_gm5piKnrS4"));

            var configCurso = new CursoController(null, null, null, userMock.Object, VideoMoq.Object, cookMock.Object);

            var guardarCom = configCurso.AgregarVideoAlCursoForm(2, "VideoMoq");

            Assert.IsInstanceOf<RedirectToActionResult>(guardarCom);
        }


        [Test]
        public void UsuarioEliminaDeSuLista()
        {
            var userMock = new Mock<IUsuarioRepository>();
            var cursoMock = new Mock<ICursoRepository>();
            var cookMock = new Mock<ICookieAuthService>();

            userMock.Setup(o => o.ObtenerUsuarioLogin(null)).Returns(new Usuario() { });

            cursoMock.Setup(o => o.DesagregarCurso(2,new Usuario()));

            var configCurso = new CursoController(null, cursoMock.Object, null, userMock.Object, null, cookMock.Object);

            var guardarCom = configCurso.desagregarCurso(2);

            Assert.IsInstanceOf<RedirectToActionResult>(guardarCom);
        }

    }
}





