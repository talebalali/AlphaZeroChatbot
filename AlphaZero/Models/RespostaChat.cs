using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaZero.Models
{
    [Table("Chat")]
    public class RespostaChat
    {
        [Column("Id")]
        [Display(Name = "chatID")]
        public int Id { get; set; }

        [Column("Resposta")]
        [Display(Name = "Resposta")]
        public string Resposta { get; set; }

        [Column("Message")]
        [Display(Name = "Message")]
        public string Message { get; set; }

    }
}
