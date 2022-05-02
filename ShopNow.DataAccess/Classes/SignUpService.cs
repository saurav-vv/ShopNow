using Microsoft.EntityFrameworkCore;
using ShopNow.DataAccessLayer.DataSet.EntityModel;
using ShopNow.DataAccessLayer.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNow.DataAccessLayer.Classes
{
    public class SignUpService :ISignUpService
    {
        private readonly ShopNowDBContext _context;

        public SignUpService(ShopNowDBContext context)
        {
            _context = context;
        }

        public async Task<int> addNewUser(SignUpEntity user)
        {
            _context.SignUpEntities.Add(user);
            await _context.SaveChangesAsync();
            return user.SignUpID;
        }

        public async Task<List<SignUpEntity>> GetAllUsersAsync()
        {
            var result = await _context.SignUpEntities.ToListAsync();
            return result;
        }

        public async Task<SignUpEntity> GetUserByID(int id)
        {
            var result = await _context.SignUpEntities.FindAsync(id);
            return result;
        }
    }
}
