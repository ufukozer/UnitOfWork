using System.Collections.Generic;
using System.Linq;
using WebApplication7.Models;

namespace WebApplication7
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly XContext _xContext;
        public UserRepository(XContext xContext) : base(xContext)
        {
            _xContext = xContext;
        }
        public IEnumerable<User> GetBirthdayPeople()
        {
            return _xContext.Users.Where(a => a.Id == 3);
        }
    }
}
