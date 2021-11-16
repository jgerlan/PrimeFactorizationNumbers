using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using System;

namespace PrimeFactorizationNumbers.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                Console.Write("Entre com um Número Inteiro: ");

                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("* Número de Entrada: " + num);
                Console.WriteLine();

                for (int i = 1; i <= num; i++)
                {
                    int numeroDivisores = 0;

                    if (num % i == 0)
                    {
                        Console.Write("* Número divisor: ");
                        Console.WriteLine("" + i);
                        Console.WriteLine();

                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                numeroDivisores++;
                            }
                        }

                        if (numeroDivisores == 2)
                        {
                            Console.WriteLine("* Divisor primo: " + i);
                            Console.WriteLine();
                        }
                    }
                }
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
