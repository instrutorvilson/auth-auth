﻿using Autenticacao.Models;
using Microsoft.EntityFrameworkCore;

namespace Autenticacao.Data
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> usuarios { get; set; }
    }
}
