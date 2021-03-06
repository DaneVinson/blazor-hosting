using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Hosting = Microsoft.Extensions.Hosting;

namespace Blazor.Server.Host
{
    public class Program
    {
        public static void Main(string[] args) =>
            Hosting.Host
                .CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(builder => { builder.UseStartup<Startup>(); })
                .Build()
                .Run();
    }
}
