using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp4.Modelos;

namespace WinFormsApp4.Data
{
    public class AppDbContext: DbContext
    {
        public  DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=LAPTOP-47AGEGV3\SQLEXPRESS;
                   Database=BD_OptimizacionSQL_Practica;
                    Trusted_connection=true;
                    TrustServerCertificate=true;");
        }
    }
}
