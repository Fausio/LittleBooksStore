﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBooksStore.Services
{
    interface IRepository<T>
    {
        T GetT(int id);

        IEnumerable<T> GetAll();
        bool Add(T item);
        bool Delete(T item);
        bool Edit(T item);
    }
}