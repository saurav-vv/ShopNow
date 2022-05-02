using ShopNow.DataAccessLayer.CommonEntity;
using System.ComponentModel.DataAnnotations;

namespace ShopNow.DataAccessLayer.DataSet.EntityModel
{
    public class SignUpEntity : Entity
    {
        [Key]
        public int SignUpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Re_Password { get; set; }
        public int UserStatus { get; set; }
        public string Address { get; set; }
       
    }
}
