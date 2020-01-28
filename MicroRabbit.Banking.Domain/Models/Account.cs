using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int AccountType { get; set; }
        public int AccountBalance { get; set; }

    }
}
