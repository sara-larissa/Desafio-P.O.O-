using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_P.O.O___Livros.Models
{
    public class Livro
    {
        public string? Nome { get; set; }
        public List<Autor> DadosAutor = new List<Autor>();
    }
}