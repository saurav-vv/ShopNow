using ShopNow.Common.DataModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopNow.BusinessLayer.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UsersModel>> getAllUsersCatAsync();
    }
}
