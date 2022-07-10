using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionLine.DB.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            using (var session = FluentNHibernateHelper.OpenSession())
            {
                using var transaction = session.BeginTransaction();
                session.Save(entity);
                transaction.Commit();
            }
        }

        public T GetById(int id)
        {
            using (var session = FluentNHibernateHelper.OpenSession())
            {
                var item1 = session.Get<T>(id);
                return item1;
            }
        }

        public void Remove(T entity)
        {
            using (var session = FluentNHibernateHelper.OpenSession())
            {
                using var transaction = session.BeginTransaction();
                session.Delete(entity);
                transaction.Commit();
            }
        }

        public void Update(T entity)
        {
            using (var session = FluentNHibernateHelper.OpenSession())
            {
                using var transaction = session.BeginTransaction();
                session.Update(entity);
                session.Save(entity);
                transaction.Commit();
            }
        }
    }
}
