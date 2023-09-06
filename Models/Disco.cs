using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Aula_3.Models
{
    public class Disco
    {
        [DisplayName("Nome do Disco:")]
        [StringLength(50, ErrorMessage =
            "O campo Nome permite no máximo 50 caracteres!")]
        public string disco { get; set; }
        [Required]
        public string artista { get; set; }

        public string faixas { get; set; }
    }
}