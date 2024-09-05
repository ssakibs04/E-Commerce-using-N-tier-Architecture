using Shopping.Data;
using Shopping.DataAccessLayer.Infrastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccessLayer.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
         public ICategoryRepository Category{ get; private set; } 
        public UnitOfWork(ApplicationDbContext context) 
        {
            _context = context;
            Category =new CategoryRepository(context);
        }
      

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
