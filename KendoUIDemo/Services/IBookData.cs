﻿using KendoUIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KendoUIDemo.Services
{
    public interface IBookData
    {
        IEnumerable<Book> GetAll();
    }
}
