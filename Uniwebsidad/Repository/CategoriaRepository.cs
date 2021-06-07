using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uniwebsidad.BaseDatos;
using Uniwebsidad.Models;

namespace Uniwebsidad.Repository
{
    public interface ICategoriaRepository
    {
        public List<Categoria> Categorias();
    }

    public class CategoriaRepository : ICategoriaRepository
    {
        private CalidadContext _context;

        public CategoriaRepository(CalidadContext context)
        {
            _context = context;
        }

        public List<Categoria> Categorias()
        {
            var categorias = _context._Categorias.ToList();
            return categorias;
        }
    }
}
