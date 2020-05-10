using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blog.Models.Blog.Postagem
{
    public class PostagemOrmService
    {
        private readonly DatabaseContext _databaseContext;

        public PostagemOrmService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<PostagemEntity> ObterPostagens()
        {
            return _databaseContext.postagem
                .Include(p => p.categoria)
                .Include(p => p.Revisoes)
                .Include(p => p.Comentarios)
                .ToList();
        }

        public List<PostagemEntity> ObterPostagensPopulares()
        {
            return _databaseContext.postagem
                .Include(a => a.Autor)
                .OrderByDescending(c => c.Comentarios.Count)
                .Take(4)
                .ToList();
        }
    }
}
