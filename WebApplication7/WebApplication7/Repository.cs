using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7
{
    public class Repository<T> : IRepository<T> where T:class
    {
        private XContext _xContext;
        public Repository(XContext xContext)//constractor
        {
            _xContext = xContext;
        }
        public void Add(T model)
        {
            _xContext.Set<T>().Add(model);
        }

        public IEnumerable<T> GetAll()
        {
            return _xContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _xContext.Set<T>().Find(id);
        }
    }
}
