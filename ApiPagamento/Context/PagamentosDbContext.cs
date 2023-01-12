using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiPagamento.Models;

namespace ApiPagamento.PagamentosDbContext
{
    public class PagamentoDbContext : DbContext
    {

    
    
       public PagamentoDbContext (DbContextOptions<PagamentoDbContext> options) : base(options) 
       { 

       }

       public DbSet<Pagamento> Pagamentos {get; set;} 
        
    }
}