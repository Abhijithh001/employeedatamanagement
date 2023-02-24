﻿using Microsoft.EntityFrameworkCore;
using MiniProject.Models.Domain;

namespace MiniProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
