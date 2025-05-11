
namespace EShop.Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string? UserName { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [StringLength(11, MinimumLength = 11)]
        public string? PhoneNumber { get; set; }

        [MaxLength(30)]
        public string Password { get; set; }
        public string? Avatar { get; set; }
        public DateTime RegisterDate { get; set; }
        public string ActiveCode { get; set; }
        public bool IsActive { get; set; }

        #region NavigationProperties
        public ICollection<Role> Roles { get; set; }
        #endregion

    }
}
