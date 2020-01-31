using MediatR;
using MicroRabbit.Banking.Aplication.Interfaces;
using MicroRabbit.Banking.Aplication.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository.Implementations;
using MicroRabbit.Transfer.Domain.EventHandlers;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Services.Implementations;
using MicroRabbit.Transfer.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            
            // Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp => 
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            // Subscriptions 
            services.AddTransient<TransferEventHandler>();

            // Domain Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            // Domain Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();


            //Application Services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();
            
            // Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();

            services.AddTransient<ITransferRepository, TransferRepository>();            
            services.AddTransient<TransferDbContext>();

        }
    }
}
