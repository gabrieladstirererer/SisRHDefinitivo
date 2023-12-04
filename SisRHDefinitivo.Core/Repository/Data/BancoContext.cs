﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SisRHDefinitivo.Core.Models;
using SisRHDefinitivo.Core.Models.Views;

namespace SisRHDefinitivo.Core.Repository.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }


        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<ConsultarFuncionariosView> DadosFuncionarios { get; set; }
    }
}
