﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models.Blog.Etiqueta;

namespace Blog.Models.Blog.Postagem
{
    public class PostagemEtiquetaEntity
    
    {
        [Key]
        public int Id { get; set; }
        public PostagemEntity Postagem { get; set; }
        public EtiquetaEntity Etiqueta { get; set; }
    }
}
