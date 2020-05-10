using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models.Blog.Etiqueta;

namespace Blog.Models.Blog.Postagem.Categoria
{
    public class CategoriaEntity
    {
        [Key] public int Id { get; set; }

        [MaxLength(128)] [Required] public string Nome { get; set; }

        public ICollection<PostagemEntity> Postagens { get; set; }

        public ICollection<EtiquetaEntity> Etiquetas { get; set; }


        public CategoriaEntity()
        {
            Postagens = new List<PostagemEntity>();
            Etiquetas = new List<EtiquetaEntity>();
        }
    }
}
