﻿using DressShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressShop.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Category>
    {
        void Update(Company obj);
     
    }
}
