using Microsoft.EntityFrameworkCore;

namespace Part_A.Context
{
    public class CovidVaccineContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=LAPTOP-HF5FGEQ6;Database=BancoDatos;Trusted_Connection=True;");
    }
}