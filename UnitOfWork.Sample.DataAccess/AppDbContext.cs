﻿namespace UnitOfWork.Sample.DataAccess
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.Configuration;
    using Microsoft.Extensions.Configuration;
    using UnitOfWork.Sample.DataAccess.Entities;

    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Article> Articles { get; set; }
        
       
    }
}
