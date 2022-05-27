using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactList.Model;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace ContactList.Pages.Login
{
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public RegisterModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Contact Contact { get; set; }

        public async Task OnGet()
        {
            
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid) // save valid account to database
            { 
				Contact.password = hashCode(Contact.password);
                await _db.Contact.AddAsync(Contact);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
		
		private string hashCode(string password){ // function that generates hash password
			byte[] salt = new byte[128 / 8];
			using (var rngCsp = new RSACryptoServiceProvider())
			{
                rngCsp.Encrypt(salt, false);
			}

			string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
				password: password,
				salt: salt,
				prf: KeyDerivationPrf.HMACSHA256,
				iterationCount: 100000,
				numBytesRequested: 256 / 8));

            return hashed;
		}
    }
}
