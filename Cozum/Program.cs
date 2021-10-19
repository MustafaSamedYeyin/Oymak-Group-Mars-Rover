﻿using Cozum.Concrete.Models;
using Cozum.Interfaces.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Cozum
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                                           .AddScoped<IRobot, Robot>()
                                           .AddScoped<ICordinate, Cordinate>()
                                           .BuildServiceProvider();


            Console.Read();
        }
    }
}
