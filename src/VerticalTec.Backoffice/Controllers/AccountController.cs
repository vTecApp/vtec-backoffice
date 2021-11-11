using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using VerticalTec.Backoffice.Models;
using VerticalTec.Shared;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace VerticalTec.Backoffice.Controllers
{
    public class AccountController : Controller
    {
        private readonly IDatabase _database;

        public AccountController(IDatabase database)
        {
            _database = database;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (!ModelState.IsValid)
                return RedirectToAction("AccessDenined");

            using (var conn = await _database.ConnectAsync())
            {
                var cmdText = "select a.StaffID, a.StaffFirstName, a.StaffLastName," +
                    " a.LangID, b.StaffRoleID, b.StaffRoleName " +
                    " from staffs a " +
                    " join StaffRole b " +
                    " on a.StaffRoleID = b.StaffRoleID" +
                    " where a.StaffLogin=@username" +
                    " and a.StaffPassword=@password and a.Deleted=0 and a.Activated=1";
                var userParam = _database.CreateDataParameter("@username", model.Username);
                var passParam = _database.CreateDataParameter("@password", model.Password.ToSha1());

                var dtStaff = new DataTable();
                using (var reader = await _database.ExecuteReaderAsync(conn, cmdText, userParam, passParam))
                {
                    dtStaff.Load(reader);
                }

                var staff = dtStaff.AsEnumerable()
                    .Select(r => new
                    {
                        StaffID = r["StaffID"],
                        LangID = r["LangID"],
                        RoleID = r["StaffRoleID"],
                        RoleName = r["StaffRoleName"],
                        FullName = $"{r["StaffFirstName"]} {r["StaffLastName"]}"
                    }).FirstOrDefault();

                if (staff != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim("StaffID", staff.StaffID?.ToString()),
                        new Claim("LangID", staff.LangID?.ToString()),
                        new Claim("StaffName", staff.FullName),
                        new Claim("RoleID", staff.RoleID?.ToString()),
                        new Claim("RoleName", staff.RoleName?.ToString())
                    };

                    await HttpContext.SignInAsync(
                        new ClaimsPrincipal(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme)));
                }
                else
                {
                    return RedirectToAction("AccessDenied");
                }
            }

            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return Redirect("/");
            }
        }

        public IActionResult AccessDenied(string returnUrl = null)
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
