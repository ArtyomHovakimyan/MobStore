using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobStore.Models;

namespace MobStore.Services.ImplementServices
{
    public class MobileAction : IMobileAction
    {
        private readonly IMobileAction _mobile;
        public MobileAction(IMobileAction mobile)
        {
            _mobile = mobile;
        }
        public void AddAsync(Phone phone)
        {
           
        }

        public void EditAsync(Phone phone)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Phone> GetPhonesById(int mobileid)
        {
            throw new NotImplementedException();
        }

        public void RemoveAsync(Phone phone)
        {
            throw new NotImplementedException();
        }
    }
}
