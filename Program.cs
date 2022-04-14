using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(x =>{
                 x.UseUrls("http://localhost:5003", "https://localhost:5004");
                 x.UseStartup<Startup>();
                //  x.UseKestrel(opts =>
                // {
                //     // Bind directly to a socket handle or Unix socket
                //     // opts.ListenHandle(123554);
                //     // opts.ListenUnixSocket("/tmp/kestrel-test.sock");
                //     opts.Listen(IPAddress.Loopback, port: 5002);
                //     opts.ListenAnyIP(5003);
                //     opts.ListenLocalhost(5004, opts => opts.UseHttps());
                //     opts.ListenLocalhost(5005, opts => opts.UseHttps());
                // });
                });
        }
    }
} 