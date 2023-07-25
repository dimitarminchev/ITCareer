using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Eventures.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly ILogger<RegisterModel> logger;

        public RegisterModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ILogger<RegisterModel> logger)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = 3)]
            [RegularExpression(@"^[\w_\-.*~]{3,}$")]
            public string Username { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = 5)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [Display(Name = "First Name")]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = 3)]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = 3)]
            public string LastName { get; set; }

            [Required]
            [Display(Name = "UCN")]
            [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
                MinimumLength = 10)]
            [RegularExpression(@"\d{10}")]
            public string UniqueCitizenNumber { get; set; }
        }

        // GET
        public IActionResult OnGet(string returnUrl = null)
        {
            returnUrl = returnUrl ?? this.Url.Content("~/");
            
            if (this.User.Identity.IsAuthenticated)
            {
                return this.LocalRedirect(returnUrl);
            }
            
            this.ReturnUrl = returnUrl;

            return this.Page();
        }

        // POST
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? this.Url.Content("~/");
            
            if (this.User.Identity.IsAuthenticated)
            {
                return this.LocalRedirect(returnUrl);
            }
            
            if (this.ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = this.Input.Username, 
                    Email = this.Input.Email,
                    FirstName = this.Input.FirstName,
                    LastName = this.Input.LastName,
                    UniqueCitizenNumber = this.Input.UniqueCitizenNumber
                };
                var result = await this.userManager.CreateAsync(user, this.Input.Password);
                if (result.Succeeded)
                {
                    this.logger.LogInformation("User created a new account with password.");

                    await this.signInManager.SignInAsync(user, isPersistent: false);
                    return this.LocalRedirect(returnUrl);
                }

                foreach (var error in result.Errors)
                {
                    this.ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return this.Page();
        }
    }
}