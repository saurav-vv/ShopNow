using ShopNow.DataAccessLayer.DataSet.EntityModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopNow.DataAccessLayer.Interfaces
{
    public interface IUserService
    {
        Task<List<UsersCategory>> getAllUsersCatAsync();
    }
}
