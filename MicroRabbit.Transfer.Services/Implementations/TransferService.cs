using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Transfer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Services.Implementations
{
    public class TransferService : ITransferService
    {

        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _eventBus;
        public TransferService(ITransferRepository transferRepository, IEventBus eventBus)
        {
            _transferRepository = transferRepository;
            _eventBus = eventBus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }

        //public void Transfer(AccountTransfer accountTransfer)
        //{
        //    var createTransferCommand = new CreateTransferCommand(
        //        accountTransfer.FromAccount
        //        , accountTransfer.ToAccount
        //        , accountTransfer.TransferAmount);

        //    _eventBus.SentCommand(createTransferCommand);
        //}
    }
}
