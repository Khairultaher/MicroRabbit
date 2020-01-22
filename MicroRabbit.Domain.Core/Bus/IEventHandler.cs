using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent>: IEventHandler
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {
    }
}
