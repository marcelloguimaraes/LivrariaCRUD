using System;

namespace LivrariaCRUD.Models
{
    public class Livro
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public DateTime DataPublicacao { get; set; }
    }
}