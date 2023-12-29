using Autofac;
using BackgroundLogger;
using Database;
using EmailSender;
using Services;

namespace Aggregator;
internal class DependencyContainer
{
    internal static IContainer Configure()
    {
        ContainerBuilder builder = new();
        builder.RegisterType<RepositoryManager>().As<IRepositoryManager>();
        builder.RegisterType<EmailManager>().As<IEmailManager>();
        builder.RegisterType<MyLogger>().As<IMyLogger>();
        builder.RegisterType<ServiceManager>().As<IServiceManager>();
        return builder.Build();
    }
}
