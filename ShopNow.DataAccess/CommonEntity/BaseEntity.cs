using System;

namespace ShopNow.DataAccessLayer.CommonEntity
{
    public class Entity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        //public Entity()
        //{
        //    UpdatedDate = DateTime.Now;
        //    CreatedDate ??= UpdatedDate;
        //}
    }
}
