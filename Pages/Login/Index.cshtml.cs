using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactList.Model;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System;
using System.Web;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ContactList.Pages.Login
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<Contact> Contacts { get; set; } // list of contacts
        [BindProperty]
        public Contact Contact { get; set; } // variable that will contains e-mail and password

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnPost()
        {
            Contacts = await _db.Contact.ToListAsync();

            if (Contact.email != null && Contact.password != null)
            {
                foreach(Contact con in Contacts)
                {
                    if(con.email == Contact.email && con.password == hashCode(Contact.password)) // validate login
                    {
                        HttpContext.Session.SetString("usermail", con.email); // start session
                        HttpContext.Session.SetString("username", con.name);
                        HttpContext.Session.SetString("usersurname", con.surname);
                        return Redirect("./Index");
                    }
                }

                return Page();
            }
            else
            {
                return Page();
            }
        }

        private string hashCode(string password) // function that create hash password
        {
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
