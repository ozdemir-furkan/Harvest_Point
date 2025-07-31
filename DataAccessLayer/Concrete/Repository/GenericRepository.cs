﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Contexts;

namespace DataAccessLayer.Concrete.Repository
{
    
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Delete(T t)
        {
            using var context = new HarvestContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new HarvestContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var context = new HarvestContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new HarvestContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new HarvestContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
