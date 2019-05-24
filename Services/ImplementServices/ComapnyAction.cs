using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobStore.Models;

namespace MobStore.Services.ImplementServices
{
    public class ComapnyAction : ICompanyAction
    {
        public IEnumerable<Company> Companies
        {
            get
            {
                return new List<Company>
                     {
                         new Company { CompanyName = "Lg", Address = "Als" },
                         new Company { CompanyName = "Samsung", Address = "All address" }
                     };
            }
        }
        
        
    }
}
