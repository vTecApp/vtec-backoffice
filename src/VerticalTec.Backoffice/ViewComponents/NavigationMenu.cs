using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VerticalTec.Shared;

namespace VerticalTec.Backoffice.ViewComponents
{
    public class NavigationMenu : ViewComponent
    {
        private readonly IDatabase _database;

        public NavigationMenu(IDatabase database)
        {
            _database = database;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dtPermission = new DataTable();
            using (var conn = await _database.ConnectAsync())
            {
                var claims = HttpContext.User.Claims;
                var roleId = claims.Where(c => c.Type == "RoleID").Select(c => c.Value).FirstOrDefault();
                var langId = claims.Where(c => c.Type == "LangID").Select(c => c.Value).FirstOrDefault();

                var langIdParam = _database.CreateDataParameter("@langId", langId);
                var roleIdParam = _database.CreateDataParameter("@roleId", roleId);
                var cmdText = @"select pgn.PermissionGroupName, pn.PermissionItemName, p.PermissionItemUrl, p.PermissionItemIDParent 
	                        from permissionitem p
	                        join staffpermission sp
	                        on p.PermissionItemID=sp.PermissionItemID
	                        join permissiongroupname pg
	                        on p.PermissionGroupID=pg.PermissionGroupID
	                        join permissiongroupname pgn
	                        on p.PermissionGroupID=pgn.PermissionGroupID
	                        join permissionitemname pn
	                        on p.PermissionItemID = pn.PermissionItemID
                            where p.Deleted=0 and pn.LangID=@langId and pgn.LangID=@langId and sp.StaffRoleID = @roleId";

                using (var reader = await _database.ExecuteReaderAsync(conn, cmdText, langIdParam, roleIdParam))
                {
                    dtPermission.Load(reader);
                }
            }
            return View();
        }
    }
}
