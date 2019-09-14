using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7
{
    public class PhoneRepository : Repository<Phone>, IPhoneRepository
    {
        private readonly XContext _xContext;
        public PhoneRepository(XContext xContext) : base(xContext)
        {
            _xContext = xContext;
        }
    }
}
