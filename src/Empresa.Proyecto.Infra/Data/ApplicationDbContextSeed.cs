using Empresa.Proyecto.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Empresa.Proyecto.Infra.Data
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(MyProjectContext dbContext)
        {
            await dbContext.Database.EnsureDeletedAsync();
            await dbContext.Database.EnsureCreatedAsync();
            dbContext.SimpleEntities.AddRange(
                new SimpleEntity { Name = "Nuevo", Value="2345$", Created = new DateTime(2023, 01, 03), Modified = new DateTime(2023, 10, 03) },
                new SimpleEntity { Name = "Existente", Value = "8560$", Created = new DateTime(2019, 11, 28), Modified = new DateTime(2021, 09, 30) },
                new SimpleEntity { Name = "Reconstruido", Value = "4520$", Created = new DateTime(2017, 03, 27), Modified = new DateTime(2022, 12, 14) });
             


            await dbContext.SaveChangesAsync();
        }
    }
}
