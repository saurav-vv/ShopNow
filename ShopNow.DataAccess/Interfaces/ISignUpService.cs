using ShopNow.DataAccessLayer.DataSet.EntityModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopNow.DataAccessLayer.Interfaces
{
    public interface ISignUpService
    {
        Task<int> addNewUser(SignUpEntity signUp);
        Task<SignUpEntity> GetUserByID(int id);
        Task<List<SignUpEntity>> GetAllUsersAsync();
    }
}
