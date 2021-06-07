using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uniwebsidad.BaseDatos;
using Uniwebsidad.Models;

namespace Uniwebsidad.Repository
{
    public interface IDetalleUsuarioCursoRepository
    {
        public Curso DetalleCurso(int id);
    }

    public class DetalleUsuarioCursoRepository : IDetalleUsuarioCursoRepository
    {
        private readonly CalidadContext _context;

        public DetalleUsuarioCursoRepository(CalidadContext context)
        {
            _context = context;
        }

        public Curso DetalleCurso(int id)
        {
            var cursoDetalle = _context._Cursos.FirstOrDefault(o => o.Id == id);
            return cursoDetalle;
        }
    }
}
