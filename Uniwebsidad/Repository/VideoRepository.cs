using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uniwebsidad.BaseDatos;
using Uniwebsidad.Models;

namespace Uniwebsidad.Repository
{
    public interface IVideoRepository
    {
        public List<Video> VideosDelCurso(int Id);
        public void AgregarVideo(int IdVideo, string video);
    }
    public class VideoRepository : IVideoRepository
    {
        private CalidadContext _context;

        public VideoRepository(CalidadContext context)
        {
            _context = context;
        }

        public void AgregarVideo(int IdVideo, string video)
        {
            Video nuevoVideo = new Video();
            nuevoVideo.Link = video;
            nuevoVideo.IdCurso = IdVideo;
            _context._Videos.Add(nuevoVideo);
            _context.SaveChanges();
        }

        public List<Video> VideosDelCurso(int Id)
        {
            var videoCurso = _context._Videos.Where(o => o.IdCurso == Id).ToList();
            return videoCurso;
        }
    }
}
