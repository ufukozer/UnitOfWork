using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly XContext _xContext;
        public UnitOfWork(XContext xContext)
        {
            _xContext = xContext;
            UserRepository = new UserRepository(xContext);
            CategoryRepository = new CategoryRepository(xContext);
            OrderRepository = new OrderRepository(xContext);
            PhoneRepository = new PhoneRepository(xContext);
        }
        public IUserRepository UserRepository { get; set; }
        public ICategoryRepository CategoryRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public IPhoneRepository PhoneRepository { get; set; }

        public void Dispose()
        {
            //Dispose garbage collectora objeyi gönderir.
            _xContext.Dispose();
        }
        public int Complete()
        {
            return _xContext.SaveChanges();
        }

        
    }
}
