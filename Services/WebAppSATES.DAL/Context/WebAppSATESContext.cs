using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppSATES.Domain.Entities;
using WebAppSATES.Domain.Entities.Identity;

namespace WebAppSATES.DAL.Context
{
    public class WebAppSATESContext : IdentityDbContext<User, Role, string>
    {
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public WebAppSATESContext(DbContextOptions<WebAppSATESContext> options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder model)
        //{
        //    base.OnModelCreating(model);
        //}
    }
}
