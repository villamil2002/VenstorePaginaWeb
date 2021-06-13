using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaginaWebGaes23.Models
{
    public class DBClientesDROP
    {
        [Key]
        public int IdDocumento { get; set; }

        [Required]
        [StringLength (50, MinimumLength = 2)]
        public string Nombres { get; set; }

        [Required]
        [StringLength (50)]
        public string Apellidos { get; set; }

        // double    bool
    }
}