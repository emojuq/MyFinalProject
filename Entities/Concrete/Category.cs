using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın eğer kalırsa ileride sıkıntı yaşarız.

    public class Category:IEntity
    {   
        //proje 2. burayı yaptık

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
