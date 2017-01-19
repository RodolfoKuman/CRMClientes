using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CRMClientes.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        public string NombreCompleto { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            userIdentity.AddClaim(new Claim("NombreCompleto", this.NombreCompleto));
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<CRMClientes.Models.TipoActividad> TipoActividades { get; set; }
        public System.Data.Entity.DbSet<CRMClientes.Models.TipoCliente> TipoClientes { get; set; }
        public System.Data.Entity.DbSet<CRMClientes.Models.Actividad> Actividades { get; set; }
        public System.Data.Entity.DbSet<CRMClientes.Models.Contacto> Contactos { get; set; }
        public System.Data.Entity.DbSet<CRMClientes.Models.Direccion> Direcciones { get; set; }
        public System.Data.Entity.DbSet<CRMClientes.Models.Email> Emails { get; set; }
        public System.Data.Entity.DbSet<CRMClientes.Models.Telefono> Telefonos { get; set; }
        public System.Data.Entity.DbSet<CRMClientes.Models.Campania> Campanias { get; set; }
        public System.Data.Entity.DbSet<CRMClientes.Models.Cliente> Clientes { get; set; }
    }
}