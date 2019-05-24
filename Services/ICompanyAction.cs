using MobStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobStore.Services
{
    interface ICompanyAction
    {
        IEnumerable<Company> Companies { get; }
    }
}
