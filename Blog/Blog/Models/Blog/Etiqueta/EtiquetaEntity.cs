using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Etiqueta
{
    public class EtiquetaEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        
    }
}
