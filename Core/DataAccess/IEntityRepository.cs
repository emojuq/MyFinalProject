
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{   //namespace'i değiştirerek Core.DataAccess yaptık ve DataAccess'teki IEntityRepository'i Core projesine taşıdık. yani kes yapıştır olayı.
    //Core katmanı evrensel katmanımızdır.
    //Core katmanı diğer katmanları referans almaz. yukarıdaki using entities.abstractı sil ve ıentity'de üzerine gelerek using de.
   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        // class : referans tip olabilir demek.
        // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir demek.
        // new() : new'lenebilir olmalı.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>>filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       
    }
}
