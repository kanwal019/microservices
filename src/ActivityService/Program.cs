using Library.Common.Commands;
using Library.Common.Services;

namespace Service.Activity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceHost.Create<Startup>(args)
                .UseRabbitMq()
                .SubscribeToCommand<CreateActivity>()
                .Build()
                .Run();
        }
    }
}
