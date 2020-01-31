﻿
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Context
{
    public class TransferDbContext: DbContext
    {
        public DbSet<TransferLog> TransferLogs { get; set; }
        public TransferDbContext(DbContextOptions options):base(options)
        { 

        }
    }
}