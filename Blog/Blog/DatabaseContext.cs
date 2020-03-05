using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models.Blog.Etiqueta;
using Blog.Models.Blog.Postagem;
using Blog.Models.Blog.Postagem.Revisao;
using Blog.Models.Blog.Postagem.Autor;
using Blog.Models.Blog.Postagem.Categoria;
using Microsoft.EntityFrameworkCore;
using Blog.Models.Blog.Postagem.Revisao.Classificacao;
using Blog.Models.Blog.Postagem.Revisao.Comentario;

namespace Blog
{
    public class DatabaseContext : DbContext
    {
        public DbSet<AutorEntity> autor { get; set; }
        public DbSet<CategoriaEntity> categorias { get; set; }
        public DbSet<EtiquetaEntity> etiqueta { get; set; }
        public DbSet<PostagemEntity> postagem { get; set; }
        public DbSet<RevisaoEntity> revisao { get; set; }
        public DbSet<ClassificacaoEntity> classificacao  { get; set; }
        public DbSet<ComentarioEntity> comentario  { get; set; }
     




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("Server=localhost;User=root; password=JEan8451; Database = pwablog");
        }

    }
}
