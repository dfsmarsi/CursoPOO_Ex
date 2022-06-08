namespace ExComposicao2.Entidades
{
    public class Comentario
    {
        public string Texto { get; set; }

        public Comentario(string comentarios) => Texto = comentarios;
    }
}
