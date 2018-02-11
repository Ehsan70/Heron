using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Heron
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // A host is been setup which will configure a server and request processing pipelines. 
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        // CreateDefaultBuilder sets up the application with some defaults. Configures a web server called Kastrol (internal server).
        // UseStartup sets up the start up class. I.e. specifies the type of the start up class in this case StartUp class. 
    }
}
