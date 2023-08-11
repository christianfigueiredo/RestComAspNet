using System.ComponentModel.DataAnnotations.Schema;

namespace RestComAspNet.Model
{
    [Table("person")]
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("primeiro_nome")]
        public string PrimeiroNome { get; set; }

        [Column("sobrenono")]
        public string Sobrenome { get; set;}

        [Column("endereco")]
        public string Endereco { get; set; }

        [Column("genero")]
        public string Genero { get; set;}
    }
}
