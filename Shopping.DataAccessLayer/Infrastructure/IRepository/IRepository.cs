﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccessLayer.Infrastructure.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetByID(Expression<Func<T,bool>>predicate);
        void add(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entity);



    }
}
