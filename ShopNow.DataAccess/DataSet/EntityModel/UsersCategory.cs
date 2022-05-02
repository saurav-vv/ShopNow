using System.ComponentModel.DataAnnotations;

namespace ShopNow.DataAccessLayer.DataSet.EntityModel
{
    public class UsersCategory
    {
        [Key]
        public int UserID { get; set; }
        public string UserStatus { get; set; }
    }
}