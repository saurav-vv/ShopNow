using AutoMapper;
using ShopNow.Common.DataModel;
using ShopNow.DataAccessLayer.DataSet.EntityModel;

namespace ShopNow.Common.ObjectsMapper
{
   public class UsersCatProfiles :Profile
    {
        public UsersCatProfiles()
        {
            CreateMap<UsersModel, UsersCategory>().ReverseMap();
            CreateMap<SignUpModel, SignUpEntity>().ReverseMap();
        }
    }
}
