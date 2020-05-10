using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Postagem.Revisao.Classificacao
{
    public class ClassificacaoEntity
    {

        public int Id { get; set; }
        public RevisaoEntity Revisao;
        public bool Classificacao { get; set; }
    }
}
