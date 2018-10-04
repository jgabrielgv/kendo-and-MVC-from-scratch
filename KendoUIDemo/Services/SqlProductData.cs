using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KendoUIDemo.Data;
using KendoUIDemo.Models;

namespace KendoUIDemo.Services
{
    public class SqlProductData : IProductData
    {
        private ApplicationDbContext _context;

        public SqlProductData(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
    }
}
