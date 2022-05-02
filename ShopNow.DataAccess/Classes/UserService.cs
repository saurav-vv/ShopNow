using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShopNow.DataAccessLayer.Interfaces;
using ShopNow.DataAccessLayer.DataSet.EntityModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopNow.DataAccessLayer.Classes
{
    public class UserService : IUserService
    {
        private readonly ShopNowDBContext _context;

        public UserService(ShopNowDBContext context)
        {
            _context = context;
        }

        public async Task<List<UsersCategory>> getAllUsersCatAsync()
        {
            var records = await _context.UsersCategories.ToListAsync();
                return records;
        }
    }
}
