// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using CarRentalApp.Models;
using CarRentalApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarRentalApp.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public IndexModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public ManageProfileViewModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
        }

        //private async Task LoadAsync(AppUser user)
        //{
        //    var userName = await _userManager.GetUserNameAsync(user);
        //    var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

        //    Username = userName;

        //    Input = new InputModel
        //    {
        //        PhoneNumber = phoneNumber
        //    };
        //}

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            Input = new ManageProfileViewModel
            {
                Username = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                DateOfBirth = user.DateOfBirth,
                AddressLine1 = user.AddressLine1,
                AddressLine2 = user.AddressLine2,
                City = user.City,
                Country = user.Country,
                DriversLicenseNumber = user.DriversLicenseNumber
            };
            
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            user.PhoneNumber = Input.PhoneNumber ?? user.PhoneNumber;

            if (!string.IsNullOrWhiteSpace(Input.Username))
            {
                user.UserName = Input.Username;
            }
            if (!string.IsNullOrWhiteSpace(Input.FirstName))
            {
                user.FirstName = Input.FirstName;
            }
            if (!string.IsNullOrWhiteSpace(Input.LastName))
            {
                user.LastName = Input.LastName;
            }
            //if (!string.IsNullOrWhiteSpace(Input.PhoneNumber))
            //{
            //    user.PhoneNumber = Input.PhoneNumber;
            //}
            if (Input.DateOfBirth.HasValue)
            {
                user.DateOfBirth = Input.DateOfBirth;
            }
            if (!string.IsNullOrWhiteSpace(Input.AddressLine1))
            {
                user.AddressLine1 = Input.AddressLine1;
            }
            if (!string.IsNullOrWhiteSpace(Input.AddressLine2))
            {
                user.AddressLine2 = Input.AddressLine2;
            }
            if (!string.IsNullOrWhiteSpace(Input.City))
            {
                user.City = Input.City;
            }
            if (!string.IsNullOrWhiteSpace(Input.Country))
            {
                user.Country = Input.Country;
            }
            if (!string.IsNullOrWhiteSpace(Input.DriversLicenseNumber))
            {
                user.DriversLicenseNumber = Input.DriversLicenseNumber;
            }

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return RedirectToPage();
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
