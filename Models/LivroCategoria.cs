using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroCategoria
    {
        public int LivroId { get; set; }
        [ForeignKey("LivroId")]

        public Livro Livro { get; set; } = null!;

        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]

        public string Cateogria { get; set; } = null!;
    }
}