using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MateoOrtegaVacasPrueba.Models;

    public class MateoOrtegaVacasPruebaBD : DbContext
    {
        public MateoOrtegaVacasPruebaBD (DbContextOptions<MateoOrtegaVacasPruebaBD> options)
            : base(options)
        {
        }

        public DbSet<MateoOrtegaVacasPrueba.Models.Cliente> Cliente { get; set; } = default!;
    }
