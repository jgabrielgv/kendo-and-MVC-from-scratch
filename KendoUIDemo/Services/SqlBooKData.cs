using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KendoUIDemo.Data;
using KendoUIDemo.Models;

namespace KendoUIDemo.Services
{
    public class SqlBooKData : IBookData
    {
        private BooksDbContext _context;

        public SqlBooKData(BooksDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books;
        }
    }
}
