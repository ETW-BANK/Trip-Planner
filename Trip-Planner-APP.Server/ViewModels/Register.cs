using System.ComponentModel.DataAnnotations;

namespace Trip_Planner_APP.Server.ViewModels
{
    public class Register
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        [Compare("Password",ErrorMessage =("* Passwords Don't Match"))]

        public string PasswordConfirmation { get; set; }

        public string Address { get; set; }
    }
}
