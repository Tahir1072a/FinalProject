using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // class : Referans tip olabilir demek, new() demek : new'lenebilir olmalı
    // generic constraint yapmış olduk where ile
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        List<T> GetAllByCategory(int categoryId);
    }
}
