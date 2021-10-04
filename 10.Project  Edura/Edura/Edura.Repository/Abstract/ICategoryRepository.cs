﻿using Edura.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Edura.Repository.Abstract
{
    public interface ICategoryRepository
    {
        Category Get(int id);
        IQueryable<Category> GetAll();
        IQueryable<Category> Find(Expression<Func<Category, bool>> predicate);
        void Add(Category entity); 
        void Delete(Category entity);
        void Edit(Category entity);
        void Save();
    }
}
