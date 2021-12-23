using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SeGCore3._1Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeGCore3._1Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BakimTipi> BakimTipi { get; set; }
    }
}
