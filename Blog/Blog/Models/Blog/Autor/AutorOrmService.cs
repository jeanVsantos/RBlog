using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models.Blog.Postagem.Autor;

namespace Blog.Models.Blog.Autor
{
    public class AutorOrmService
    {
        private readonly DatabaseContext _databaseContext;
        public AutorOrmService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<AutorEntity> ObterAutores()
        {
            return _databaseContext.autor.ToList();
        }

        public AutorEntity ObterAutorPorId(int idCategoria)
        {
            var autor = _databaseContext.autor.Find(idCategoria);

            return autor;
        }

        public List<AutorEntity> PesquisarAutoresPorNome(string nomeAutor)
        {
            return _databaseContext.autor.Where(c => c.Nome.Contains(nomeAutor)).ToList();
        }
    }
}
