using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaginaWebGaes23.Models
{
    public class DBCiudadesDROP
    {

        [Key]
        [StringLength (5, MinimumLength = 5)]
        [Display (Name ="Código Ciudad")]
        public string IdCiudad { get; set; }
        

        [StringLength (60, MinimumLength = 3)]
        [Display (Name ="Nombre Ciudad")]
        public string Descripcion { get; set; }

    }
}