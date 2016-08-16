using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Web.ExamenFinal.Models;

[assembly: OwinStartupAttribute(typeof(Web.ExamenFinal.Startup))]
namespace Web.ExamenFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            CrearUsuarioyRoles();
            ConfigurarAutorizacion(app);
           // ConfigInjector();
        }
        internal void CrearUsuarioyRoles()
        {
            using (var context = new WebExamenFinalDbConexto())
            {

                var AdministrarRol = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
                var AdministrarUsuario = new UserManager<WebExamenFinalUsuario>(new UserStore<WebExamenFinalUsuario>(context));

                // In Startup iam creating first Admin Role and creating a default Admin User    
                if (!AdministrarRol.RoleExists("Administrador"))
                {

                    // first we create Admin rool   
                    var role = new IdentityRole();
                    role.Name = "Administrador";
                    AdministrarRol.Create(role);

                    //Here we create a Admin super user who will maintain the website                  

                    var user = new WebExamenFinalUsuario
                    {
                        UserName = "hernandezceliz@gmail.com",
                        Email = "hernandezceliz@gmail.com"
                    };

                    string userPassword = "Nozokiana&2004";

                    var userCreation = AdministrarUsuario.Create(user, userPassword);

                    //Add default User to Role Admin   
                    if (userCreation.Succeeded)
                        AdministrarUsuario.AddToRole(user.Id, "Administrador");


                }
            }
        }
    }
}
