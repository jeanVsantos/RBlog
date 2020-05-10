using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Postagem.Revisao
{
    public class RevisaoEntity
    {
        [Key]
        public int Id { get; set; }
        public string Texto { get; set; }
        public int Versao { get; set; }
        public PostagemEntity Postagem;
        public DateTime DataCriacao { get; set; }

    }
}
