using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7
{
    public interface IRepository<T> where T : class //T ile generic olduğunu söyledik
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T model);
    }
}
