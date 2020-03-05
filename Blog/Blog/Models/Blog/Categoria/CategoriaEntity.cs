﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Postagem.Categoria
{
    public class CategoriaEntity
    {   
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Nome { get; set; }
    }
}
