﻿using ApiUsuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario>? Usuarios { get; set; }
        
    }
}
