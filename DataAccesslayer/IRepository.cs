﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer
{
   
      public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByCode(int code);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int code);
        void Save();
    }

}
