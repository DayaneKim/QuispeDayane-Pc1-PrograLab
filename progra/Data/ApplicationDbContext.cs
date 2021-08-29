using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace progra.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         public DbSet<progra.Models.Proforma> DataCarrito { get; set; }
        public DbSet<progra.Models.Producto> DataProductos { get; set; }

        public DbSet<progra.Models.Pedido> DataPedidos { get; set; }
    }
}
