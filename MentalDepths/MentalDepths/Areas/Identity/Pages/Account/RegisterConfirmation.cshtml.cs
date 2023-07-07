// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable


namespace MentalDepths.Areas.Identity.Pages.Account
{
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    using MentalDepths.Services.Web.Interfaces;
    using ApplicationUser = Data.Models.ApplicationUser;
    
    [AllowAnonymous]
    public class RegisterConfirmationModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _sender;
        private readonly IUserService userService;
        private readonly SignInManager<ApplicationUser> signInManager;

        public RegisterConfirmationModel(UserManager<ApplicationUser> userManager, IEmailSender sender, IUserService userService, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _sender = sender;
            this.userService = userService;
            this.signInManager = signInManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Email { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "Activation Code")]
            [RegularExpression(Common.ModelRegulations.CodeSender.Regex,
                ErrorMessage = Common.ModelRegulations.CodeSender.RegexErrorMessage)]

            [StringLength(Common.ModelRegulations.CodeSender.Lenght, MinimumLength = Common.ModelRegulations.CodeSender.Lenght,
                ErrorMessage = Common.ModelRegulations.CodeSender.LenghtErrorMessage)]
            public string Code { get; set; }
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public bool DisplayConfirmAccountLink { get; set; }


        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string EmailConfirmationUrl { get; set; }

        public async Task<IActionResult> OnGetAsync(string email, string returnUrl = null)
        {
            if (email == null)
            {
                return RedirectToPage("/Index");
            }
            returnUrl = returnUrl ?? Url.Content("~/");

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound($"Unable to load user with email '{email}'.");
            }

            Email = email;
            // Once you add a real email sender, you should remove this code that lets you confirm the account
            //DisplayConfirmAccountLink = true;
            //if (DisplayConfirmAccountLink)
            //{
            //    var userId = await _userManager.GetUserIdAsync(user);
            //    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            //    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            //    EmailConfirmationUrl = Url.Page(
            //        "/Account/ConfirmEmail",
            //        pageHandler: null,
            //        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
            //        protocol: Request.Scheme);
            //}
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string email, string returnUrl = null)
        {
            if (email == null)
            {
                return RedirectToPage("/Index");
            }
            returnUrl = returnUrl ?? Url.Content("~/");

            var user = await _userManager.FindByEmailAsync(email);
            var userId = await _userManager.GetUserIdAsync(user);

            var code = userService.GetConfiramtionCodeFromId(userId);
            if (code == Input.Code)
            {
                userService.SetEmailConfirmationToTrue(userId);
                userService.DisposeOfConfirmedCodes(userId);
                await signInManager.SignInAsync(user, isPersistent: false);

                return Redirect(EmailConfirmationUrl = Url.Page(
                    "/Account/ConfirmEmail",
                    pageHandler: null,
                    values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                    protocol: Request.Scheme));
            }
            else
            { 
                return Page();
            }
            return Page();
        }
    }
}
