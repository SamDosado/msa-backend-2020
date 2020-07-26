using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Phase_1_Backend;
namespace Phase_1_Backend.Data
{
    public class AddressContext :DbContext
    {
        public AddressContext() { }

        public AddressContext(DbContextOptions<AddressContext> options) : base(options) { }

        public DbSet<Address> Address { get; set; }
        public static System.Collections.Specialized.NameValueCollection AppSettings { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();


            optionsBuilder.UseSqlServer(configuration.GetConnectionString("msaDBConnection"));
        }
    }
}
