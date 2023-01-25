using System.Net.Mime;
namespace EnounSenac.Models
{
    public class Contato
    {
         public int Id { get; set; }
    public string? Nome { get; set; }

    public string? email { get; set; }

      public string? Mensagem { get; set; }

    }
}