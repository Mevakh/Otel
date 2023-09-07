﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Absract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        List<Comment> GetListByFilter(Func<object, bool> p);
    }
}