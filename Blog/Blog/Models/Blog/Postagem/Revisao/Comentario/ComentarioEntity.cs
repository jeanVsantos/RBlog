using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Postagem.Revisao.Comentario
{
    public class ComentarioEntity
    {

        public int Id { get; set; }
        public RevisaoEntity Revisao;
        public string Texto { get; set; }
        public string Autor { get; set; }
        public DateTime Data;

    }
}
