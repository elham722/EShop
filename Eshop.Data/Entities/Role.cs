
namespace EShop.Data.Entities
{
    public class Role
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }



        #region NavigationProperties
        public ICollection<User> Users { get; set; }
        #endregion
    }
}
