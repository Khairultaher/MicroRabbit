using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext: DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public BankingDbContext(DbContextOptions options):base(options)
        { 

        }
    }
}
