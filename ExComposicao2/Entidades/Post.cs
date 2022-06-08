using System;
using System.Collections.Generic;
using System.Text;

namespace ExComposicao2.Entidades
{
    public class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentario(Comentario comentarios) => Comentarios.Add(comentarios);

        public void RemoverComentario(Comentario comentarios) => Comentarios.Remove(comentarios);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" - likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentários: ");
            foreach (Comentario c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }

            return sb.ToString();
        }
    }
}
