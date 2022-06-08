using ExComposicao2.Entidades;
using System;

namespace ExComposicao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario comentario1 = new Comentario("Comentario 1");
            Comentario comentario2 = new Comentario("Comentario 2");
            Post post1 = new Post(DateTime.Parse("06/06/2022 22:22:22"),
                "Titulo post 1",
                "Conteudo do post 1",
                10);
            post1.AddComentario(comentario1);
            post1.AddComentario(comentario2);
            Console.WriteLine(post1);
        }
    }
}
