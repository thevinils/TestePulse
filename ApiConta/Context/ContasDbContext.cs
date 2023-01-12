using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiConta.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiConta.ContasDbContext
{
    public class ContaDbContext : DbContext
    {
       public ContaDbContext (DbContextOptions<ContaDbContext> options) : base(options) 
       { 

       }

       public DbSet<Conta> Contas {get; set;}
        
    }
}