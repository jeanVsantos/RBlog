using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models.Blog.Postagem.Autor;
using Blog.Models.Blog.Postagem.Categoria;
using Blog.Models.Blog.Etiqueta;
using Blog.Models.Blog.Postagem.Revisao;
using Blog.Models.Blog.Postagem.Revisao.Comentario;
using Blog.Models.Blog.Postagem.Revisao.Classificacao;

namespace Blog.Models.Blog.Postagem
{
    public class PostagemEntity
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }


        public AutorEntity Autor { get; set; }
        public CategoriaEntity categoria { get; set; }

        public List<PostagemEtiquetaEntity> PostagensEtiquetas { get; set; }

        public List<EtiquetaEntity> Etiqutas { get; set; }
        public List<RevisaoEntity> Revisoes { get; set; }
        public List<ComentarioEntity> Comentarios { get; set; }

        public List<ClassificacaoEntity> Classificacoes { get; set; }



        public PostagemEntity()
        {
            PostagensEtiquetas = new List<PostagemEtiquetaEntity>();
            Revisoes = new List<RevisaoEntity>();
            Comentarios = new List<ComentarioEntity>();
            Classificacoes = new List<ClassificacaoEntity>();
        }
    }
}
