using System;

namespace WebApplication7
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; set; }
        ICategoryRepository CategoryRepository { get; set; }
        IOrderRepository OrderRepository { get; set; }
        IPhoneRepository PhoneRepository { get; set; }
        int Complete();
    }
}
