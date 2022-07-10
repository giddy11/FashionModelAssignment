using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        T GetById(int id);
        void Remove(T entity);
    }
}
