using Microsoft.EntityFrameworkCore;

namespace Proyecto_final.Context
{
    public class CovidVaccineContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=DESKTOP-NHNTHSU;Database=BancoDatos;Trusted_Connection=True;");
    }
}