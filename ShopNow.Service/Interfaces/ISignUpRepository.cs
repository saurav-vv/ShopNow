using ShopNow.Common.DataModel;
using ShopNow.DataAccessLayer.DataSet.EntityModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopNow.BusinessLayer.Interfaces
{
   public interface ISignUpRepository
    {
        Task<List<SignUpModel>> GetAllUsersAsync();

        Task<SignUpModel> GetUserByID(int id);

        Task<int> addNewUser(SignUpModel signUpModel);

    }
}
