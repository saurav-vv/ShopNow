using AutoMapper;
using ShopNow.BusinessLayer.Interfaces;
using ShopNow.Common.DataModel;
using ShopNow.DataAccessLayer.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopNow.BusinessLayer.Classes
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserService _user;
        private readonly IMapper _mapper;
        public UserRepository(IUserService user, IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }

        public async Task<List<UsersModel>> getAllUsersCatAsync()
        {
            var result = await _user.getAllUsersCatAsync();
            return _mapper.Map<List<UsersModel>>(result);


        }
    }
}
