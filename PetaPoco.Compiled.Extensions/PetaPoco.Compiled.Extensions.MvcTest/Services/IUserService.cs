using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetaPoco.Compiled.Extensions.MvcTest.Services
{
    using PetaPoco.Compiled.Extensions.MvcTest.DBContexts;
    using PetaPoco.Compiled.Extensions.MvcTest.Models;

    public interface IUserService
    {
        IList<User> GetAll();
    }

    public class UserService : IUserService
    {
        private IPetaPocoDBContext _context;

        public UserService(IPetaPocoDBContext context)
        {
            _context = context;
        }
        public IList<User> GetAll()
        {
            return _context.Fetch<User>();
        }
    }
}
