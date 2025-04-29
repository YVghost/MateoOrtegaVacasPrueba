using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MateoOrtegaVacasPrueba.Models;

    public class MateoBDC : DbContext
    {
        public MateoBDC (DbContextOptions<MateoBDC> options)
            : base(options)
        {
        }

        public DbSet<MateoOrtegaVacasPrueba.Models.Cliente> Cliente { get; set; } = default!;

public DbSet<MateoOrtegaVacasPrueba.Models.Recompensa> Recompensa { get; set; } = default!;

public DbSet<MateoOrtegaVacasPrueba.Models.Reserva> Reserva { get; set; } = default!;
    }
