using MobStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobStore.Services
{
    public interface IMobileAction
    {
        IEnumerable<Phone> GetPhonesById(int mobileid);
        void AddAsync(Phone phone);
        void RemoveAsync(Phone phone);
        void EditAsync(Phone phone);

    }
}
