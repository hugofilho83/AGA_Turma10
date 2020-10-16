using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDessafioAcademy.Models.Context
{
    public class DataBasePadrao : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            JToken jAppSettings = JToken.Parse(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "appsettings.json")));

            string strCnn = jAppSettings["ConnectionStrings"]["ConexaoPadrao"].ToString();
           
            optionsBuilder.UseSqlServer(strCnn);
        }
    }
}
