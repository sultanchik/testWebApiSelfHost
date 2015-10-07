using System;
using System.Web;
using System.Web.Http;
using System.Web.Http.SelfHost;
using Topshelf;

namespace WebApiSelfhosting
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<Service>(s =>
                {
                    s.SetServiceName("ProductService Example");
                    s.ConstructUsing(name => new Service());
                    s.WhenStarted(svc => svc.Start());
                    s.WhenStopped(svc => svc.Stop());
                });

                x.RunAsLocalSystem();
                x.SetDescription("ProductService WebAPI selfhosting Windows Service Example");
                x.SetDisplayName("ProductService Example");
                x.SetServiceName("ProductService");
            });

            Console.ReadLine();
        }
    }
}
