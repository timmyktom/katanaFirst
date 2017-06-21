﻿using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8080";
            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("My First Katana App Started");
                Console.ReadKey();
                Console.WriteLine("My First Katana App Stopping");
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseWelcomePage();
            app.Run(ctx =>
            {
                return ctx.Response.WriteAsync("Hello World My First Katana App - Timmy");
            });
        }
    }
}
