using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSQL.Models
{
    public class LoginContext : DbContext
    {
        public DbSet<LoginItem> LoginItems { get; set; }
        //public Task<ActionResult<IEnumerable<LoginItem>>> InMemoryLoginData { get; internal set; }

        //public LoginContext(DbContextOptions<LoginContext> options) : base (options)
        //{
            
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("server=localhost;database=sqlcsharp;user=root;password=MySQL54321");
        }

       
    }
}
