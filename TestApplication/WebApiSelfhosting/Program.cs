using System;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.SelfHost;


namespace WebApiSelfhosting
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Service();

            s.Start();

            Console.ReadLine();

            s.Stop();
        }
    }
}
