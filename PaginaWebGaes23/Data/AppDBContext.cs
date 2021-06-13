using PaginaWebGaes23.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PaginaWebGaes23.Data
{
    public class AppDBContext : DbContext
    {

        public AppDBContext() : base("DefaultConnection")
        {

        }

        public DbSet<DBClientesDROP> PaginaWebGaes23 { get; set; }

        public DbSet<DBCiudadesDROP> PaginaWebGaes231 { get; set; }
    }
}