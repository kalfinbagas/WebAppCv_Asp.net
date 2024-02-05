using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CvWebApp.Models;

namespace CvWebApp.Data
{
    public class ApplicationContext : DbContext
    {
  public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
    {
        
    }
        public DbSet<CV> CVs {get;set;}
    }

}