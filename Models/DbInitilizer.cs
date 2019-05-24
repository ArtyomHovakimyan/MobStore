using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MobStore.Data;
using MobStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobStore.Models
{
    public class DbInitilizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            ApplicationDbContext context =
                   applicationBuilder.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            if (!context.Compnaies.Any())
            {
                context.Compnaies.AddRange(Companies.Select(c => c.Value));
            }

            if (!context.Phones.Any())
            {
                context.AddRange
                (
                    new Phone
                    {
                        Title = "Galaxy S",
                        Price = 12.95M,
                        ShortDescription = " A beverage prepared from coffee beans",
                        Company = Companies["Samsung"],
                        ImageUrl = "iphone_3.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                    },
                    new Phone
                    {
                        Title = "Galaxy",
                        Price = 12.95M,
                        ShortDescription = "A very refreshing Russian beverage",
                        Company = Companies["Samsung"],
                        ImageUrl = "iphone_4.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                    },
                    new Phone
                    {
                        Title = "Note 9 ",
                        Price = 12.95M,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                        Company = Companies["LG"],
                        ImageUrl = "iphone_1.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Company> companies;
        public static Dictionary<string, Company> Companies
        {
            get
            {
                if (companies == null)
                {
                    var cmpyList = new Company[]
                    {
                        new Company { CompanyName = "Samsung", Address="Address  change" },
                        new Company { CompanyName = "LG", Address="Change" }
                    };

                    companies = new Dictionary<string, Company>();

                    foreach (Company cmpy in cmpyList)
                    {
                        companies.Add(cmpy.CompanyName, cmpy);
                    }
                }

                return companies;
            }
        }
    }
}
