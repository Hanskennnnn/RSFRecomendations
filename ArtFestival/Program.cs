using Microsoft.EntityFrameworkCore;
using System;

namespace ArtFestival
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var options = new DbContextOptionsBuilder<ArtFestivalDbContext>()
                .UseNpgsql("Host=localhost;Port=5432;Database=eventsdb;Username=postgres;Password=12345")
                .Options;

            Application.Run(new Form1());



        }
    }
}