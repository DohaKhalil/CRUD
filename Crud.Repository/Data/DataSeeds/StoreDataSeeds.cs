using CRUDSystem.Data;
using CRUDSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Crud.Repository.Data.DataSeeds
{
    public static class StoreDataSeeds
    {
        public static async Task SeedsAsync(StoreDBContext DbContext )
        {

            if (!DbContext.categorey.Any()) //If catetegory have daata return true if not return fals
            {
                var CategoryData = File.ReadAllText("../Crud.Repository/Data/DataSeeds/Category.json");

                var Category = JsonSerializer.Deserialize<List<Categorey>>(CategoryData);
                if (Category is not null && Category.Count > 0)
                {
                    foreach (var item in Category)
                    {
                        await DbContext.Set<Categorey>().AddAsync(item);
                        await DbContext.SaveChangesAsync();

                    }
                    await DbContext.SaveChangesAsync();

                }
            }

            if (!DbContext.productes.Any()) //If products have daata return true if not return fals
            {
                var ProductsData = File.ReadAllText("../Crud.Repository/Data/DataSeeds/producte.json");

                var Products = JsonSerializer.Deserialize<List<Producte>>(ProductsData);
                if (Products is not null && Products.Count > 0)
                {
                    foreach (var producte in Products)
                    {
                        await DbContext.Set<Producte>().AddAsync(producte);
                        await DbContext.SaveChangesAsync();

                    }
                    await DbContext.SaveChangesAsync();

                }
            }




        }
    }
}
