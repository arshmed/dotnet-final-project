﻿using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    // generic constraint
    // class: referans tip
    // IEntity : IEntity olabilir veya IEntity implemente eden bir class olabilir
    // new() : new'lenebilir olmali. (Yani IEntity;nin kendisi olamaz cunku o bir interface)
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

