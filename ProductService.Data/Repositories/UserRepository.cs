using ProductService.Data.Context;
using ProductService.Domain.Entities;
using ProductService.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductService.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>,IUserRepository
    {
        public UserRepository(DataContext context) : base(context) { }
    }
}
