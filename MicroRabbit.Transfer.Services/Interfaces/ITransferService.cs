using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Services.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
