using System.ComponentModel.DataAnnotations;

namespace Trip_Planner_APP.Server.ViewModels
{
    public class Login
    {
        [Required(ErrorMessage ="* User Name is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="* PassWord is Required")]
        [DataType(DataType.Password)]

       
        public string Password { get; set; }

        [Display(Name = "Remeber Me")]

        public string RememberMe { get; set; }
    }
}
