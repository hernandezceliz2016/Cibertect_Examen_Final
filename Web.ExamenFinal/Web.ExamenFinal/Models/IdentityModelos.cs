using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Web.ExamenFinal.Models
{
    public class WebExamenFinalUsuario : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<WebExamenFinalUsuario> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class WebExamenFinalDbConexto : IdentityDbContext<WebExamenFinalUsuario>
    {
        public WebExamenFinalDbConexto()
            : base("IdentityExamenFinal")
        {
        }

        public static WebExamenFinalDbConexto Create()
        {
            return new WebExamenFinalDbConexto();
        }
    }
}