using AutoMapper;
using ShopNow.BusinessLayer.Interfaces;
using ShopNow.Common.DataModel;
using ShopNow.DataAccessLayer.DataSet.EntityModel;
using ShopNow.DataAccessLayer.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopNow.BusinessLayer.Classes
{
    public class SignUpRepository : ISignUpRepository
    {
        private readonly IMapper _mapper;
        private readonly ISignUpService _signUp;
        public SignUpRepository(IMapper mapper, ISignUpService signUp)
        {
            _signUp = signUp;
            _mapper = mapper;
        }
        public async Task<int> addNewUser(SignUpModel signUpModel)
        {
            
            return await _signUp.addNewUser(_mapper.Map<SignUpEntity>(signUpModel));
        }

        public async Task<List<SignUpModel>> GetAllUsersAsync()
        {
            var result = await _signUp.GetAllUsersAsync();
            return _mapper.Map<List<SignUpModel>>(result);
        }

        public async Task<SignUpModel> GetUserByID(int id)
        {
            var result = await _signUp.GetUserByID(id);
            return _mapper.Map<SignUpModel>(result);
        }
    }
}
