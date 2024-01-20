using DressShop.DataAccess.Data;
using DressShop.DataAccess.Repository.IRepository;
using DressShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DressShop.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(Category entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Category> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }

        IEnumerable<Category> IRepository<Category>.GetAll(string? includeProperties)
        {
            throw new NotImplementedException();
        }
    }
}
