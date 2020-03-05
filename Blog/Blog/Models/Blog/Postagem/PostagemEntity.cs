using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models.Blog.Postagem.Autor;
using Blog.Models.Blog.Postagem.Categoria;
using Blog.Models.Blog.Etiqueta;
using Blog.Models.Blog.Postagem.Revisao;

namespace Blog.Models.Blog.Postagem
{
    public class PostagemEntity
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        
        public AutorEntity Autor;
        public CategoriaEntity categoria;
       
        public List<EtiquetaEntity> Etiqutas;
        public List<RevisaoEntity> Revisoes;
    }
}
