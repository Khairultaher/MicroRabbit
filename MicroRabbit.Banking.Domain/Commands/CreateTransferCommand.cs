using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand:TransferCommand
    {
        public CreateTransferCommand( int to, int from, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;

        }
    }
}
