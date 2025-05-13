
namespace EShop.Core.DTOs.User
{
    public class RegisterViewModel
    {
        [Display(Name = "نام کاربری")]
        [MaxLength(50,ErrorMessage = "{0} نمینواند بیشتر از{1} کاراکتر باشد")]
        public string? UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "ایمیل الزامی است")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نمی باشد")]
        [MaxLength(50, ErrorMessage = "{0} نمینواند بیشتر از{1} کاراکتر باشد")]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "رمز عبور الزامی است")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "رمز عبور باید حداقل 6 کاراکتر باشد")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).*$",
            ErrorMessage = "رمز عبور باید شامل حروف بزرگ، حروف کوچک و عدد باشد")]
        public string Password { get; set; }

        [Display(Name = "تکرار رمز عبور")]
        [Required(ErrorMessage = "تکرار رمز عبور الزامی است")]
        [Compare("Password",ErrorMessage = "تکرار کلمه عبور مغایرت دارد")]
        public string RePassword { get; set; }
    }
}
